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

        public ViewCitasController(ViewCitas repo)
        {
            repository = repo;
        }
        // GET: ViewHorario
        public ActionResult Index()
        {
            return View(repository);
        }
    }
}