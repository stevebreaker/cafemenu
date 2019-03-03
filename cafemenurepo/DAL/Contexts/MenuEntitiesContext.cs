using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using cafemenurepo.DAL;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace cafemenurepo.DAL.Contexts
{
    public class MenuEntitiesContext : DbContext
    {

        public MenuEntitiesContext() : base("MenuEntities") {
        }


        DbSet<MenuItemDTO> menuItems { get; set; }
        DbSet<DietaryOptionDTO> dietaryOptions { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}
