using System.Web.Mvc;
using Horario.Domain.Abstract;
using System.Linq;
using Horario.Domain.Entities;
using Horario.WebUI.Models; 

namespace Horario.WebUI.Controllers
{
    public class CitaController : Controller
    {
        private ICitaRepository repository;

        public CitaController(ICitaRepository repo)
        {
            repository = repo;
        }

        public ViewResult Index()
        {
            return View(repository.Citas);
        }
        public ViewResult Edit(string nomina , string folio,  string date, string startTime, string endTime, string correo)
        {
            Cita c = new Cita();
            nomina = c.Nomina;
            folio = c.Folio;


            DicaViewModel model = new DicaViewModel
            {
                
                CitaViewModel = new CitaViewModel { Nomina = nomina, Folio = folio, DateStr = date, Start_Time = startTime, End_Time = endTime, Correo = correo}
            };
            return View(model); 
        }
    }
}

