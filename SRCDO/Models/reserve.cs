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
    
    public partial class reserve
    {
        public int idReserve { get; set; }
        public int idUser { get; set; }
        public int idField { get; set; }
        public string idStatus { get; set; }
        public System.DateTime dateBegin { get; set; }
        public System.DateTime dateEnd { get; set; }
    
        public virtual client client { get; set; }
        public virtual field field { get; set; }
        public virtual status status { get; set; }
    }
}
