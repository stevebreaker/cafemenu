using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using cafemenucore.DTO;

namespace cafemenurepo.DAL
{
    [Table("menu_schedule")]
    public class MenuScheduleDTO : IMenuScheduleDTO
    {
        public int Id { get; set; }


        [Column("menu_day_id")]
        public int DayId { get; set; }

        [ForeignKey("DayId")]
        public virtual MenuDayDTO Day { get; set; }
        

        [Column("menu_item_id")]
        public int MenuItemId { get; set; }

        [ForeignKey("MenuItemId")]
        public virtual MenuItemDTO MenuItem { get; set; }

    }
}
