using System;
using System.Collections.Generic;
using System.Text;
using cafemenucore.Models;
using cafemenucore.DTO;

namespace cafemenurepo.Repositories
{
    public interface IMenuItemsRepository
    {
        ICollection<MenuItem> Get();

        ICollection<MenuItem> Get(int Id);

        ICollection<MenuItem> Get(MenuItem menuItem);

        MenuItem Add(MenuItem menuItem);

        MenuItem Update(MenuItem menuItem);

        MenuItem Delete(MenuItem menuItem);

        MenuItem ConvertFromDTO(IMenuItemDTO menuItemDTO);

    }
}
