//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Proyecto_Web_Ingenieria_de_Software.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Horario
    {
        public int ID { get; set; }
        public string Day { get; set; }
        public bool Weekday { get; set; }
        public int OpenTime { get; set; }
        public int CloseTime { get; set; }
    
        public virtual Horas Horas { get; set; }
        public virtual Horas Horas1 { get; set; }
    }
}
