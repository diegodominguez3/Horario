using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Horario.Domain.Abstract;
using Horario.Domain.Entities; 

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
        public ViewResult Edit(string correo)
        {

            Persona persona = repository.Personas.FirstOrDefault(p => p.Correo == correo);
            return View(persona);
        }

        [HttpPost]
        public ActionResult Edit(Persona persona)
        {
            if (ModelState.IsValid)
            {
                repository.SavePersona(persona);
                TempData["message"] = string.Format("{0} salvado correctamente", persona.Correo);
                return RedirectToAction("List");
            }
            else
            {
                return View(persona);
            }
        }

        public ViewResult Create()
        {

            return View("Edit", new Persona());
        }


    }
}



