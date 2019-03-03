using System;
using System.Collections.Generic;
using System.Text;

namespace cafemenucore.Models
{
    class IMenuScheduleDTO
    {
        public int Id;
        public DateTime day;

        public virtual ICollection<IMenuItemDTO> MenuItems { get; set; }
    }
}
