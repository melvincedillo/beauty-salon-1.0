//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Proyecto_Web_Ingenieria_de_Software.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class AppointmentDetail
    {
        public int ID { get; set; }
        public int AppointmentID { get; set; }
        public int ServicioID { get; set; }
        public Nullable<int> idHora { get; set; }
    
        public virtual Horas Horas { get; set; }
        public virtual Services Services { get; set; }
        public virtual Appointment Appointment { get; set; }
    }
}