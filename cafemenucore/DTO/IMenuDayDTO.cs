using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cafemenucore.DTO
{
    public interface IMenuDayDTO
    {
        int Id { set; get; }
        DateTime Day { set; get; }
    }
}
