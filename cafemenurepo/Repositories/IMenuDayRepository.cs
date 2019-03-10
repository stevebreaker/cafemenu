using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cafemenucore.Models;
using cafemenucore.DTO;

namespace cafemenurepo.Repositories
{
   public interface IMenuDayRepository
    {

        ICollection<MenuDay> Get();

        ICollection<MenuDay> Get(DateTime startDate, DateTime endDate);

        MenuDay ConvertFromDTO(IMenuDayDTO menuDayDTO);
    }
}
