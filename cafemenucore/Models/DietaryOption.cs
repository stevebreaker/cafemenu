using System;
using System.Collections.Generic;
using System.Text;

namespace cafemenucore.Models
{
    public class DietaryOption
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<MenuItem> MenuItems { get; set; }

    }
}
