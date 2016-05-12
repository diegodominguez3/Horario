using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Horario.Domain.Concrete
{
    public class SemanaCitas
    {
        public semana Titulo { get; set; }
        public semana Hora9 { get; set; }
        public semana Hora10 { get; set; }
        public semana Hora11 { get; set; }
        public semana Hora12 { get; set; }
        public semana Hora1 { get; set; }
        public semana Hora2 { get; set; }
        public semana Hora3 { get; set; }
        public semana Hora4 { get; set; }
        public SemanaCitas(semana titulo, semana h9, semana h10, semana h11, semana h12, semana h1, semana h2, semana h3, semana h4)
        {
            Titulo = titulo;
            Hora9 = h9;
            Hora10 = h10;
            Hora11 = h11;
            Hora12 = h12;
            Hora1 = h1;
            Hora2 = h2;
            Hora3 = h3;
            Hora4 = h4;
        }
    }
}
