using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Horario.Domain.Abstract;
using Horario.Domain.Entities; 

namespace Horario.WebUI.Controllers
{
    public class DicaController : Controller
    {

        private IDicaRepository repository;


        public DicaController(IDicaRepository dicaRepository)
        {
            repository = dicaRepository;
        }

        public ViewResult List()
        {
            return View(repository);
        }
        public ViewResult Edit(string nomina)
        {
            Dica dica = repository.Dicas.FirstOrDefault(d => d.Nomina == nomina); 
            return View(dica);
        }

        [HttpPost]
        public ActionResult Edit(Dica dica)
        {
            if (ModelState.IsValid)
            {
                repository.SaveDica(dica);
                TempData["message"] = string.Format("{0} salvado correctamente", dica.Nomina);
                return RedirectToAction("List");
            }
            else
            {
                return View(dica);
            }
        }

    }

}
