//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class menu_schedule
    {
        public int id { get; set; }
        public System.DateTime day { get; set; }
        public int menu_item_id { get; set; }
    
        public virtual menu_item menu_item { get; set; }
    }
}
