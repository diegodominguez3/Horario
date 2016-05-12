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
    
        public List<Cita> Exist()
        {
            List<Cita> tabla=context.Citas.ToList();
            return tabla;
        }

        public string SaveCita(Cita cita) // si le da RC-> Go to Definition (F12) puede ver la definición de la clase
        {
            // Cita dbEntry = context.Citas;
            Cita dbEntry = new Cita();

            dbEntry.Nomina = cita.Nomina;
            dbEntry.Fecha = cita.Fecha;
            dbEntry.Hora_Inicio = cita.Hora_Inicio;
            dbEntry.Hora_Fin = cita.Hora_Fin;
            dbEntry.Correo = cita.Correo;

            List<Cita> lista = Exist();
            bool esta=true;
            string msg = "";
            string folio=" Holi";

            foreach (var c in lista)
            {
                if(c.Hora_Inicio==dbEntry.Hora_Inicio && c.Nomina==dbEntry.Nomina && c.Fecha == dbEntry.Fecha)
                {
                    esta = false;
                }
            }


            if (esta)
            {
                context.Citas.Add(dbEntry);
                List<Cita> lista2 = Exist();
                foreach(var a in lista2)
                {
                    folio = (a.Folio+1).ToString();
                }
                msg = "La cita fue salvada correctamente, el folio es " + folio;
            }
            else
            {
                msg = "Ups. Parece que la fecha y/o hora que seleccionaste ya esta ocupada. Intentalo de nuevo. ";
            }
                   
            

            /* if (dbEntry != null) //Si encontró la cita, actualiza los datos
             {
                 dbEntry.Nomina = cita.Nomina;
                 dbEntry.Fecha = cita.Fecha;
                 dbEntry.Hora_Inicio = cita.Hora_Inicio;
                 dbEntry.Hora_Fin = cita.Hora_Fin;
                 dbEntry.Correo = cita.Correo; 

             }
             else //de lo contrario, lo añade
             {

                 context.Citas.Add(cita);
             }*/
            context.SaveChanges();
            return msg;
        }


        public Cita DeleteCita(int folio)
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
