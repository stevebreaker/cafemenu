using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cafemenucore.Models
{
    public class MenuDay
    {
        public int Id;
        public DateTime Day;

        public ICollection<MenuItem> MenuItems { get; set; }

    }
}
