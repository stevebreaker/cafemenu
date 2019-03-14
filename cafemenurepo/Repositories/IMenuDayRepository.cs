using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cafemenucore.Models;
using cafemenurepo.DAL;

namespace cafemenurepo.Repositories
{
   public interface IMenuDayRepository
    {

        ICollection<MenuDay> Get();

        ICollection<MenuDay> Get(DateTime startDate, DateTime endDate);
        ICollection<MenuDay> GetNoAutomap(DateTime startDate, DateTime endDate);

        MenuDay ConvertFromDTO(MenuDayDTO menuDayDTO);
        MenuDay ConvertFromDTONoAutomap(MenuDayDTO menuDayDTO);
    }
}
