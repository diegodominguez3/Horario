using System.Collections.Generic;
using System.Linq;
using Horario.Domain.Abstract;
using Horario.Domain.Entities;


namespace Horario.Domain.Concrete
{
    public class EFCitaRepository : ICitaRepository //error común de novato, olivar hacer la clase public!!!!!!!!!
    {
        private HorarioEntities context = new HorarioEntities();
        public IEnumerable<Cita> Citas
        {
            get { return context.Citas; }
        }
    

        public void SaveCita(Cita cita) // si le da RC-> Go to Definition (F12) puede ver la definición de la clase
        {
            Cita dbEntry = context.Citas.Find(cita.Folio);

            if (dbEntry != null) //Si encontró la cita, actualiza los datos
            {
                dbEntry.Folio = cita.Folio;
                dbEntry.Nomina = cita.Nomina;
                dbEntry.Fecha = cita.Fecha;
                dbEntry.Hora_Inicio = cita.Hora_Inicio;
                dbEntry.Hora_Fin = cita.Hora_Fin;
                dbEntry.Correo = cita.Correo; 

            }
            else //de lo contrario, lo añade
            {
                context.Citas.Add(cita);
            }
            context.SaveChanges();
        }


        public Cita DeleteCita(string folio)
        {
            Cita dbEntry = context.Citas.Find(folio);
            if (dbEntry != null)
            {
                context.Citas.Remove(dbEntry);
                context.SaveChanges();
            }
            return dbEntry;
        }
    }
}
