﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace cafemenudata
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MafeMenuEntities : DbContext
    {
        public MafeMenuEntities()
            : base("name=MafeMenuEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<dietary_option> dietary_option { get; set; }
        public virtual DbSet<menu_item> menu_item { get; set; }
        public virtual DbSet<menu_schedule> menu_schedule { get; set; }
    }
}
