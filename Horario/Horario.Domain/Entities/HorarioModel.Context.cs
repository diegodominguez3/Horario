﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Horario.Domain.Entities
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class HorarioEntities : DbContext
    {
        public HorarioEntities()
            : base("name=HorarioEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Carrera> Carreras { get; set; }
        public virtual DbSet<Cita> Citas { get; set; }
        public virtual DbSet<Dica> Dicas { get; set; }
        public virtual DbSet<Horario> Horarios { get; set; }
        public virtual DbSet<Persona> Personas { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
    }
}