﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class BeautySalonEntities : DbContext
    {
        public BeautySalonEntities()
            : base("name=BeautySalonEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Calendar> Calendar { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<Factura> Factura { get; set; }
        public virtual DbSet<FacturaImagen> FacturaImagen { get; set; }
        public virtual DbSet<Holiday> Holiday { get; set; }
        public virtual DbSet<MedioPago> MedioPago { get; set; }
        public virtual DbSet<MedioPagoDetalle> MedioPagoDetalle { get; set; }
        public virtual DbSet<Modules> Modules { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<Skill> Skill { get; set; }
        public virtual DbSet<Tax> Tax { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<Horas> Horas { get; set; }
        public virtual DbSet<Permissions> Permissions { get; set; }
        public virtual DbSet<Services> Services { get; set; }
        public virtual DbSet<ServiceDetail> ServiceDetail { get; set; }
        public virtual DbSet<Horario> Horario { get; set; }
        public virtual DbSet<AppointmentDetail> AppointmentDetail { get; set; }
        public virtual DbSet<Appointment> Appointment { get; set; }
        public virtual DbSet<FacturaDetalle> FacturaDetalle { get; set; }
        public virtual DbSet<Salon> Salon { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
    
        [DbFunction("BeautySalonEntities", "FechaTerminoSinDiasInhabiles")]
        public virtual IQueryable<FechaTerminoSinDiasInhabiles_Result> FechaTerminoSinDiasInhabiles(Nullable<System.DateTime> fechaInicio, Nullable<int> dias)
        {
            var fechaInicioParameter = fechaInicio.HasValue ?
                new ObjectParameter("FechaInicio", fechaInicio) :
                new ObjectParameter("FechaInicio", typeof(System.DateTime));
    
            var diasParameter = dias.HasValue ?
                new ObjectParameter("Dias", dias) :
                new ObjectParameter("Dias", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<FechaTerminoSinDiasInhabiles_Result>("[BeautySalonEntities].[FechaTerminoSinDiasInhabiles](@FechaInicio, @Dias)", fechaInicioParameter, diasParameter);
        }
    }
}
