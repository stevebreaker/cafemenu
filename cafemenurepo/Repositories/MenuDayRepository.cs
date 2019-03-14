using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cafemenucore.DTO;
using cafemenucore.Models;
using cafemenurepo.DAL;
using cafemenurepo.DAL.Contexts;
using AutoMapper;

namespace cafemenurepo.Repositories
{
    public class MenuDayRepository : IMenuDayRepository
    {
        public ICollection<MenuDay> Get()
        {

            List<MenuDay> menuDays;

            using (var db = new MenuEntitiesContext())
            {
                menuDays = db.MenuDays.Include("MenuSchedules").ToList().Select(day => ConvertFromDTO(day)).ToList();
            }

            return menuDays;

        }

        public ICollection<MenuDay> Get(DateTime startDate, DateTime endDate)
        {

            List<MenuDay> menuDays;

            using (var db = new MenuEntitiesContext())
            {
                menuDays = db.MenuDays.Include("MenuSchedules").Where(d => d.Day >= startDate ).Where(d => d.Day <= endDate).ToList().Select(day => ConvertFromDTO(day)).ToList();

            }

            return menuDays;

        }

        public ICollection<MenuDay> GetNoAutomap(DateTime startDate, DateTime endDate)
        {

            List<MenuDay> menuDays;

            using (var db = new MenuEntitiesContext())
            {
                menuDays = db.MenuDays.Include("MenuSchedules").Where(d => d.Day >= startDate ).Where(d => d.Day <= endDate).ToList().Select(day => ConvertFromDTO(day)).ToList();

            }

            return menuDays;

        }

        public MenuDay ConvertFromDTO(MenuDayDTO menuDTO)
        {
            var config = new MapperConfiguration(cfg =>
                {
                    cfg.CreateMap<MenuDayDTO, MenuDay>().ForMember(day => day.MenuItems, opt => opt.MapFrom(day => day.MenuSchedules.Select(ms => ms.MenuItem)));
                    cfg.CreateMap<MenuItemDTO, MenuItem>();
                    cfg.CreateMap<DietaryOptionDTO, DietaryOption>();
                }
            );

            var mapper = config.CreateMapper();

            return mapper.Map<MenuDay>(menuDTO);

        }

        public MenuDay ConvertFromDTONoAutomap(MenuDayDTO menuDTO)
        {
            MenuDay day = new MenuDay
            {
                Day = menuDTO.Day,
            };


            foreach (MenuScheduleDTO menuScheule in menuDTO.MenuSchedules) {

                MenuItem newMenuItem = new MenuItem
                {
                    Id = menuScheule.MenuItem.Id,
                    Name = menuScheule.MenuItem.Name,
                    DietaryOption = new DietaryOption
                    {
                        Id = menuScheule.MenuItem.DietaryOptionId,
                        Name = menuScheule.MenuItem.DietaryOption.Name
                    },
                };

                day.MenuItems.Add(newMenuItem);

            }

            return day;

        }
    }
}
