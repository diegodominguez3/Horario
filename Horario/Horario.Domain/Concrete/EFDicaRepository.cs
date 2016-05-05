using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Horario.Domain.Abstract; // notar que esta línea permite usar la interface
using Horario.Domain.Entities; // notar que esta línea permite usar el código generado 

namespace Horario.Domain.Concrete
{
    public class EFDicaRepository : IDicaRepository
    {
        private HorarioEntities context = new HorarioEntities();
        public IEnumerable<Dica> Dicas
        {
            get { return context.Dicas; }
        }

        public void SaveDica(Dica dica) // si le da RC-> Go to Definition (F12) puede ver la definición de la clase
        {
            Dica dbEntry = context.Dicas.Find(dica.Nomina);

            if (dbEntry != null) //Si encontró al profesor, actualiza los datos
            {
                dbEntry.Nomina = dica.Nomina;
                dbEntry.Fname = dica.Fname;
                dbEntry.Lname = dica.Lname;
                dbEntry.No_Oficina = dica.No_Oficina;
                dbEntry.Imagen = dica.Imagen;
            }
            else //de lo contrario, lo añade
            {
                context.Dicas.Add(dica);
            }
            context.SaveChanges();
        }

        public Dica DeleteDica(string nomina)
        {
            Dica dbEntry = context.Dicas.Find(nomina);
            if (dbEntry != null)
            {
                context.Dicas.Remove(dbEntry);
                context.SaveChanges();
            }
            return dbEntry;
        }

    }
}
