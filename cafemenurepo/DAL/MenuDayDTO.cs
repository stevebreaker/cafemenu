using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cafemenucore.DTO;
using System.ComponentModel.DataAnnotations.Schema;

namespace cafemenurepo.DAL
{
    [Table("menu_day")]
    public class MenuDayDTO : IMenuDayDTO
    {
        public int Id { get; set; }
        public DateTime Day { get; set; }

        public ICollection<MenuScheduleDTO> MenuSchedules { get; set; }
    }
}
