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
    
    public partial class Dica
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Dica()
        {
            this.Carreras = new HashSet<Carrera>();
            this.Citas = new HashSet<Cita>();
            this.Horarios = new HashSet<Horario>();
        }
    
        public string Nomina { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string No_Oficina { get; set; }
        public byte[] Imagen { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Carrera> Carreras { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cita> Citas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Horario> Horarios { get; set; }
    }
}