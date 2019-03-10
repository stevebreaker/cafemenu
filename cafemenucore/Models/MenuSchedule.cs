using System;
using System.Collections.Generic;
using System.Text;

namespace cafemenucore.Models
{
    public class MenuSchedule
    {
        public int Id;

        public int MenuDayId;
        public MenuDay Day;

        public int MenuItemId;
        public MenuItem MenuItem;
    }
}
