using System.Web.Mvc;
using Horario.Domain.Abstract;
using System.Linq;
using Horario.Domain.Entities;

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
    }
}

