//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FarragoWebApp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TableReservation
    {
        public int id { get; set; }
        public System.DateTime DateTime { get; set; }
        public int UserId { get; set; }
        public int PersonsNumber { get; set; }
        public string Confirmed { get; set; }
        public Nullable<int> AdminId { get; set; }
        public string UserObservations { get; set; }
        public string AdminObservations { get; set; }
        public string Status { get; set; }
    
        public virtual Admin Admin { get; set; }
        public virtual User User { get; set; }
    }
}
