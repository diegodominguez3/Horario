using System;
using System.Collections.Generic;
using Horario.Domain.Entities; 

namespace Horario.Models
{
    public class CitaViewModels
    {
        public String Nomina { get; set; }
        public String Folio { get; set; }
        public DateTime Date { get; set; }
        public String DateStr { get; set;}
      

        public virtual ICollection<Cita> Citas { get; set; }


    }
}