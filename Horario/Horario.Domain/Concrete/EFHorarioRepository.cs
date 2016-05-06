using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Horario.Domain.Abstract; // notar que esta línea permite usar la interface
using Horario.Domain.Entities; // notar que esta línea permite usar el código generado 


// Horario.Domain.Entities.Horario
namespace Horario.Domain.Concrete
{
    public class EFHorarioRepository : IHorarioRepository
    {
        private HorarioEntities context = new HorarioEntities();
        public IEnumerable<Horario.Domain.Entities.Horario> Horarios
        {
            get { return context.Horarios; }
        }

        public void SaveHorario(Horario.Domain.Entities.Horario horario) // si le da RC-> Go to Definition (F12) puede ver la definición de la clase
        {
            Horario.Domain.Entities.Horario dbEntry = context.Horarios.Find(horario.ID);

            if (dbEntry != null) //Si encontró al profesor, actualiza los datos
            {
                dbEntry.ID = horario.ID;
                dbEntry.Nomia = horario.Nomia;
                dbEntry.Fecha = horario.Fecha;
                dbEntry.Hora_Inicio = horario.Hora_Inicio;
                dbEntry.Hora_Fin = horario.Hora_Fin; 
            }
            else //de lo contrario, lo añade
            {
                context.Horarios.Add(horario);
            }
            context.SaveChanges();
        }

        public Horario.Domain.Entities.Horario DeleteHorario(string ID)
        {
            Horario.Domain.Entities.Horario dbEntry = context.Horarios.Find(ID);
            if (dbEntry != null)
            {
                context.Horarios.Remove(dbEntry);
                context.SaveChanges();
            }
            return dbEntry;
        }

    }
}
