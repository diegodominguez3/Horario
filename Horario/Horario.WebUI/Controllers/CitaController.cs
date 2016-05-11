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

        public ViewResult List()
        {
            return View(repository);
        }

        public ViewResult Index()
        {
            return View(repository.Citas);
        }

        public ViewResult Edit(string nomina, string correo)
        {
            Cita cita = repository.Citas.FirstOrDefault(c => c.Nomina == nomina);
            return View(cita);
        }

        [HttpPost]
        public ActionResult Edit(Cita cita)
        {
            if (ModelState.IsValid)
            {
                repository.SaveCita(cita);
                TempData["message"] = string.Format("{0} salvado correctamente", cita.Folio);
                return RedirectToAction("Index");
            }
            else
            {
                return View(cita);
            }
        }
        public ViewResult Create()
        {

            return View("Edit", new Cita());
        }

        public ViewResult Calendario()
        {
            return View(repository);
        }


    }
}

