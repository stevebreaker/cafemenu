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


        public DbSet<MenuItemDTO> MenuItems { get; set; }
        public DbSet<MenuScheduleDTO> MenuSchedules { get; set; }
        public DbSet<DietaryOptionDTO> DietaryOptions { get; set; }
        public DbSet<MenuDayDTO> MenuDays { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}
