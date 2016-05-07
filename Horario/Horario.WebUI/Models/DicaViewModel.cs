using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Horario.Domain.Entities;

namespace Horario.WebUI.Models
{
    public class DicaViewModel
    {

        public IEnumerable<Dica> Dicas { get; set; }

        public CitaViewModel  CitaViewModel { get; set; }



    }
}