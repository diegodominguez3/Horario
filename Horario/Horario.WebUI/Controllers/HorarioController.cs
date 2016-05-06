using System.Web.Mvc;
using Horario.Domain.Abstract;
using System.Linq;
using Horario.Domain.Entities;

namespace Horario.WebUI.Controllers
{
    public class HorarioController : Controller
    {
        private IHorarioRepository repository;

        public HorarioController(IHorarioRepository repo)
        {
            repository = repo;
        }

        public ViewResult Index()
        {
            return View(repository.Horarios);
        }
    }
}
