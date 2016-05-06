using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Horario.Domain.Abstract;

namespace Horario.WebUI.Controllers
{
    public class PersonaController : Controller
    {

        private IPersonaRepository repository;


        public PersonaController(IPersonaRepository repo)
        {
            repository = repo;
        }

        public ViewResult List()
        {
            return View(repository);
        }
    }
}
