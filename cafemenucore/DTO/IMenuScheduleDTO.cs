using System;
using System.Collections.Generic;
using System.Text;

namespace cafemenucore.DTO
{
    public interface IMenuScheduleDTO
    {
        int Id { get; set; }
        int DayId { get; set; }
        int MenuItemId { get; set; }
    }
}
