using System;
using System.Collections.Generic;
using Horario.Domain.Entities; 

namespace Horario.WebUI.Models
{
    public class CitaViewModel
    {
        public String Nomina { get; set; }
        public String Folio { get; set; }
       // public DateTime Date { get; set; }
        public String DateStr { get; set;}          //aun no se sobre las horas y la fecha tal vez un parse 
        public String Start_Time { get; set;}
        public String End_Time { get; set; }
        public String Correo { get; set; }


    }
}