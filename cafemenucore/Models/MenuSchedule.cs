using System;
using System.Collections.Generic;
using System.Text;

namespace cafemenucore.Models
{
    public class MenuSchedule
    {
        public int Id;
        public DateTime day;

        public virtual ICollection<MenuItem> MenuItems { get; set; }
    }
}
