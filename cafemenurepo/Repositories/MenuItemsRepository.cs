using System;
using System.Collections.Generic;
using System.Text;
using cafemenucore.DTO;
using cafemenucore.Models;
using cafemenurepo.DAL.Contexts;
using cafemenurepo.DAL;
using AutoMapper;
using System.Linq;

namespace cafemenurepo.Repositories
{
    public class MenuItemsRepository : IMenuItemsRepository
    {
        public ICollection<MenuItem> Get()
        {

            List<MenuItem> menuItems;

            using (var db = new MenuEntitiesContext()) {
                menuItems = db.MenuItems.ToList().Select(item => ConvertFromDTO(item)).ToList();
            }

            return menuItems;

        }

        public ICollection<MenuItem> Get(int Id)
        {
            throw new NotImplementedException();
        }

        public ICollection<MenuItem> Get(MenuItem menuItem)
        {
            throw new NotImplementedException();
        }

        public MenuItem Add(MenuItem menuItem)
        {
            throw new NotImplementedException();
        }

        public MenuItem ConvertFromDTO(IMenuItemDTO menuItemDTO)
        {
            var config = new MapperConfiguration(cfg => {
                    cfg.CreateMap<MenuItemDTO, MenuItem>();
                    cfg.CreateMap<DietaryOptionDTO, DietaryOption>(); }
                );

            var mapper = config.CreateMapper();

            return mapper.Map<MenuItem>(menuItemDTO);

        }

        public MenuItem Delete(MenuItem menuItem)
        {
            throw new NotImplementedException();
        }

        public MenuItem Update(MenuItem menuItem)
        {
            throw new NotImplementedException();
        }
    }
}
