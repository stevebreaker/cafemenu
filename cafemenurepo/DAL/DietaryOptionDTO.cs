using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cafemenucore.DTO;
using System.ComponentModel.DataAnnotations.Schema;

namespace cafemenurepo.DAL
{

    [Table("dietary_option")]
    public class DietaryOptionDTO : IDietaryOptionDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
