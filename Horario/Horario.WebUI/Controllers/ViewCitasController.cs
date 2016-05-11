using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Horario.Domain.Entities;
using Horario.Domain.Abstract;
using Horario.WebUI.Models;



namespace Horario.WebUI.Controllers
{
    public class ViewCitasController : Controller
    {
        private ViewCitas repository;
        public HorarioEntities context = new HorarioEntities();
        private ICitaRepository repoCita;
        public ViewCitasController(ViewCitas repo)
        {
            repository = repo;
        }
        // GET: ViewHorario
        public ActionResult Index()
        {
            return View(repository);
        }

        public ActionResult Citas(string nomina)
        {
            List<Cita> cita = repository.Citas.Where(c => c.Nomina == nomina).ToList();
            return View(cita);
        }

        public ViewResult Edit(string nomina)
        {
            Cita cita = repository.Citas.FirstOrDefault(c => c.Nomina == nomina);
            return View(cita);
        }

        [HttpPost]
        public ActionResult Edit(Cita cita)
        {
            if (ModelState.IsValid)
            {
                repoCita.SaveCita(cita);
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

       
            


    

}
}