using System.Collections.Generic;
using Horario.Domain.Entities;
using System;
namespace Horario.WebUI.Models
{

    public class ViewCitas
    {
        private HorarioEntities context = new HorarioEntities();
        public IEnumerable<Dica> Dicas { get; set; }
        public IEnumerable<Cita> Citas { get; set; }
        public IEnumerable<Persona> Personas { get; set; }
        public IEnumerable<Carrera> Carreras { get; set; }

        public List<IEnumerable<Object>> DarCita = new List<IEnumerable<Object>>(); 
        public ViewCitas()
        {
            Dicas = context.Dicas;
            Citas = context.Citas;
            Personas = context.Personas;
            Carreras = context.Carreras; 

        }


    }
}