using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Horario.Domain.Abstract; // notar que esta línea permite usar la interface
using Horario.Domain.Entities; // notar que esta línea permite usar el código generado 

namespace Horario.Domain.Concrete
{
    public class EFPersonaRepository : IPersonaRepository
    {
        private HorarioEntities context = new HorarioEntities();
        public IEnumerable<Persona> Personas
        {
            get { return context.Personas; }
        }

        public void SavePersona(Persona persona) // si le da RC-> Go to Definition (F12) puede ver la definición de la clase
        {
            Persona dbEntry = context.Personas.Find(persona.Correo);

            if (dbEntry != null) //Si encontró al profesor, actualiza los datos
            {
                dbEntry.Correo = persona.Correo;
                dbEntry.Fname = persona.Fname;
                dbEntry.Lname = persona.Lname;
                dbEntry.Telefono = persona.Telefono; 
            }
            else //de lo contrario, lo añade
            {
                context.Personas.Add(persona);
            }
            context.SaveChanges();
        }

        public Persona DeletePersona(string ID)
        {
            Persona dbEntry = context.Personas.Find(ID);
            if (dbEntry != null)
            {
                context.Personas.Remove(dbEntry);
                context.SaveChanges();
            }
            return dbEntry;
        }

    }
}
