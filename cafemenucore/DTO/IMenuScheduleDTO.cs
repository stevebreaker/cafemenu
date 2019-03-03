using System;
using System.Collections.Generic;
using System.Text;

namespace cafemenucore.DTO
{
    public interface IMenuScheduleDTO
    {
        int Id { get; set; }
        DateTime Day { get; set; }
        int MenuItemID { get; set; }
    }
}
