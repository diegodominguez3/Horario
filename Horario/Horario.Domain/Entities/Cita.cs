//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class Cita
    {
        public int Folio { get; set; }
        public string Nomina { get; set; }
        public System.DateTime Fecha { get; set; }
        public System.TimeSpan Hora_Inicio { get; set; }
        public System.TimeSpan Hora_Fin { get; set; }
        public string Correo { get; set; }
    
        public virtual Dica Dica { get; set; }
        public virtual Persona Persona { get; set; }
    }
}
