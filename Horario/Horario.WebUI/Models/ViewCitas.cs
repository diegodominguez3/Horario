using System.Collections.Generic;
using Horario.Domain.Entities;

namespace Horario.WebUI.Models
{
    public class ViewCitas
    {
        public IEnumerable<Dica> Dicas { get; set; }
        public IEnumerable<Cita> Citas { get; set; }

    }
}