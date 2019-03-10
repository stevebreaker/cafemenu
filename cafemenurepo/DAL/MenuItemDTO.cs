using cafemenucore.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

namespace cafemenurepo.DAL
{

    [Table("menu_item")]
    public class MenuItemDTO : IMenuItemDTO
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        [Column("dietary_flag")]
        public int DietaryOptionId { get; set; }

        [ForeignKey("DietaryOptionId")]
        public virtual DietaryOptionDTO DietaryOption { get; set; }

        public ICollection<MenuScheduleDTO> MenuSchedules { get; set; }

    }
}
