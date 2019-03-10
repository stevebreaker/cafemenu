using System;
using System.Collections.Generic;
using System.Text;

namespace cafemenucore.Models
{
    public class MenuItem
    {
        public int Id;
        public string Name;
        public decimal Price;

        public int DietaryFlagID;
        public DietaryOption DietaryOption;

        public ICollection<MenuDay> MenuDays;
    }
}
