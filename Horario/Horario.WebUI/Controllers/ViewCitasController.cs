using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Horario.Domain.Entities;
using Horario.Domain.Abstract;


namespace Horario.WebUI.Controllers
{
    public class ViewCitasController : Controller
    {
        private IDicaRepository repository;

        public ViewCitasController(IDicaRepository repo)
        {
            repository = repo;
        }
        // GET: ViewHorario
        public ActionResult Index()
        {
            return View();
        }
    }
}