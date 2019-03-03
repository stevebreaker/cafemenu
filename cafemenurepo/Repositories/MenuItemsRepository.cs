using System;
using System.Collections.Generic;
using System.Text;
using cafemenucore.DTO;
using cafemenucore.Models;

namespace cafemenurepo.Repositories
{
    public class MenuItemsRepository : IMenuItemsRepository
    {
        public ICollection<MenuItem> Get()
        {
            throw new NotImplementedException();
        }

        public ICollection<MenuItem> Get(int Id)
        {
            throw new NotImplementedException();
        }

        public ICollection<MenuItem> Get(MenuItem menuItem)
        {
            throw new NotImplementedException();
        }

        public MenuItem Add(MenuItem menuItem)
        {
            throw new NotImplementedException();
        }

        public MenuItem ConvertFromDTO(IMenuItemDTO menuItemDTO)
        {
            throw new NotImplementedException();
        }

        public MenuItem Delete(MenuItem menuItem)
        {
            throw new NotImplementedException();
        }

        public MenuItem Update(MenuItem menuItem)
        {
            throw new NotImplementedException();
        }
    }
}
