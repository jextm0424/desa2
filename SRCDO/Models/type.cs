//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SRCDO.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class type
    {
        public type()
        {
            this.field = new HashSet<field>();
        }
    
        public string idType { get; set; }
        public string type1 { get; set; }
    
        public virtual ICollection<field> field { get; set; }
    }
}
