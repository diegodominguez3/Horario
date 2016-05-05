using System.Web.Mvc;
using Horario.Domain.Abstract;
using System.Linq;
using Horario.Domain.Entities;

namespace Horario.WebUI.Controllers
{
    public class CarreraController : Controller
    {
        private ICarreraRepository repository;

        public CarreraController(ICarreraRepository repo)
        {
            repository = repo;
        }

        public ViewResult Index()
        {
            return View(repository.Carreras);
        }
    }
}

