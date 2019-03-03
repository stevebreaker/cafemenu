using System;
using System.Collections.Generic;
using System.Text;

namespace cafemenucore.DTO
{
    public interface IMenuItemDTO
    {
        int Id { get; set; }
        string Name { get; set; }
        decimal Price { get; set; }
        int DietaryOptionId { get; set; }
    }
}
