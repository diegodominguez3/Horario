using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Horario.Domain.Entities;
using Horario.Domain.Abstract;
using Horario.WebUI.Models;
using Horario.Domain.Concrete; 



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
            Cita citas = repository.Citas.FirstOrDefault(c => c.Nomina == nomina);

            //CREANDO ENCABEZADO
            DateTime date = DateTime.Now;
            DateTime date1 = date.AddDays(1);
            DateTime date2 = date.AddDays(2);
            DateTime date3 = date.AddDays(3);
            DateTime date4 = date.AddDays(4);
            DateTime date5 = date.AddDays(5);
            DateTime date6 = date.AddDays(6);

            string day1 = date.DayOfWeek.ToString() + " " + date.Day.ToString();
            string day2 = date1.DayOfWeek.ToString() + " " + date1.Day.ToString();
            string day3 = date2.DayOfWeek.ToString() + " " + date2.Day.ToString();
            string day4 = date3.DayOfWeek.ToString() + " " + date3.Day.ToString();
            string day5 = date4.DayOfWeek.ToString() + " " + date4.Day.ToString();
            string day6 = date5.DayOfWeek.ToString() + " " + date5.Day.ToString();
            string day7 = date6.DayOfWeek.ToString() + " " + date6.Day.ToString();

            TimeSpan time9 = new TimeSpan(9, 00, 00);
            TimeSpan time10 = new TimeSpan(10, 00, 00);
            TimeSpan time11 = new TimeSpan(11, 00, 00);
            TimeSpan time12 = new TimeSpan(12, 00, 00);
            TimeSpan time1 = new TimeSpan(13, 00, 00);
            TimeSpan time2 = new TimeSpan(14, 00, 00);
            TimeSpan time3 = new TimeSpan(15, 00, 00);
            TimeSpan time4 = new TimeSpan(16, 00, 00);

            //CREANDO TITULO
            string mesNum = DateTime.Now.ToString("MMMM");
            string mes = mesNum + "/" + date.Year.ToString();
            semana titulo = new semana(day1, day2, day3, day4, day5, day6, day7, mes);

            string fecha = date.ToShortDateString();
            string fecha1 = date1.ToShortDateString();
            string fecha2 = date2.ToShortDateString();
            string fecha3 = date3.ToShortDateString();
            string fecha4 = date4.ToShortDateString();
            string fecha5 = date5.ToShortDateString();
            string fecha6 = date6.ToShortDateString();

            //CREANDO H9
            day1 = "Disponible";
            day2 = "Disponible";
            day3 = "Disponible";
            day4 = "Disponible";
            day5 = "Disponible";
            day6 = "Disponible";
            day7 = "Disponible";
            mes = "9:00 AM";

            foreach (var c in cita)
            {
                if (c.Fecha.ToShortDateString() == fecha && c.Hora_Inicio == time9)
                {
                    day1 = "Cita con " + c.Correo;
                }
                if (c.Fecha.ToShortDateString() == fecha1 && c.Hora_Inicio == time9)
                {
                    day2 = "Cita con " + c.Correo;
                }
                if (c.Fecha.ToShortDateString() == fecha2 && c.Hora_Inicio == time9)
                {
                    day3 = "Cita con " + c.Correo;
                }
                if (c.Fecha.ToShortDateString() == fecha3 && c.Hora_Inicio == time9)
                {
                    day4 = "Cita con " + c.Correo;
                }
                if (c.Fecha.ToShortDateString() == fecha4 && c.Hora_Inicio == time9)
                {
                    day5 = "Cita con " + c.Correo;
                }
                if (c.Fecha.ToShortDateString() == fecha5 && c.Hora_Inicio == time9)
                {
                    day6 = "Cita con " + c.Correo;
                }
                if (c.Fecha.ToShortDateString() == fecha6 && c.Hora_Inicio == time9)
                {
                    day7 = "Cita con " + c.Correo;
                }
            }

            semana h9 = new semana(day1, day2, day3, day4, day5, day6, day7, mes);

            //CREANDO H10
            day1 = "Disponible";
            day2 = "Disponible";
            day3 = "Disponible";
            day4 = "Disponible";
            day5 = "Disponible";
            day6 = "Disponible";
            day7 = "Disponible";
            mes = "10:00 AM";

            foreach (var c in cita)
            {
                if (c.Fecha.ToShortDateString() == fecha && c.Hora_Inicio == time10)
                {
                    day1 = "Cita con " + c.Correo;
                }
                if (c.Fecha.ToShortDateString() == fecha1 && c.Hora_Inicio == time10)
                {
                    day2 = "Cita con " + c.Correo;
                }
                if (c.Fecha.ToShortDateString() == fecha2 && c.Hora_Inicio == time10)
                {
                    day3 = "Cita con " + c.Correo;
                }
                if (c.Fecha.ToShortDateString() == fecha3 && c.Hora_Inicio == time10)
                {
                    day4 = "Cita con " + c.Correo;
                }
                if (c.Fecha.ToShortDateString() == fecha4 && c.Hora_Inicio == time10)
                {
                    day5 = "Cita con " + c.Correo;
                }
                if (c.Fecha.ToShortDateString() == fecha5 && c.Hora_Inicio == time10)
                {
                    day6 = "Cita con " + c.Correo;
                }
                if (c.Fecha.ToShortDateString() == fecha6 && c.Hora_Inicio == time10)
                {
                    day7 = "Cita con " + c.Correo;
                }
            }

            semana h10 = new semana(day1, day2, day3, day4, day5, day6, day7, mes);

            //CREANDO H11
            day1 = "Disponible";
            day2 = "Disponible";
            day3 = "Disponible";
            day4 = "Disponible";
            day5 = "Disponible";
            day6 = "Disponible";
            day7 = "Disponible";
            mes = "11:00 AM";

            foreach (var c in cita)
            {
                if (c.Fecha.ToShortDateString() == fecha && c.Hora_Inicio == time11)
                {
                    day1 = "Cita con " + c.Correo;
                }
                if (c.Fecha.ToShortDateString() == fecha1 && c.Hora_Inicio == time11)
                {
                    day2 = "Cita con " + c.Correo;
                }
                if (c.Fecha.ToShortDateString() == fecha2 && c.Hora_Inicio == time11)
                {
                    day3 = "Cita con " + c.Correo;
                }
                if (c.Fecha.ToShortDateString() == fecha3 && c.Hora_Inicio == time11)
                {
                    day4 = "Cita con " + c.Correo;
                }
                if (c.Fecha.ToShortDateString() == fecha4 && c.Hora_Inicio == time11)
                {
                    day5 = "Cita con " + c.Correo;
                }
                if (c.Fecha.ToShortDateString() == fecha5 && c.Hora_Inicio == time11)
                {
                    day6 = "Cita con " + c.Correo;
                }
                if (c.Fecha.ToShortDateString() == fecha6 && c.Hora_Inicio == time11)
                {
                    day7 = "Cita con " + c.Correo;
                }
            }

            semana h11 = new semana(day1, day2, day3, day4, day5, day6, day7, mes);

            //CREANDO H12
            day1 = "Disponible";
            day2 = "Disponible";
            day3 = "Disponible";
            day4 = "Disponible";
            day5 = "Disponible";
            day6 = "Disponible";
            day7 = "Disponible";
            mes = "12:00 PM";

            foreach (var c in cita)
            {
                if (c.Fecha.ToShortDateString() == fecha && c.Hora_Inicio == time12)
                {
                    day1 = "Cita con " + c.Correo;
                }
                if (c.Fecha.ToShortDateString() == fecha1 && c.Hora_Inicio == time12)
                {
                    day2 = "Cita con " + c.Correo;
                }
                if (c.Fecha.ToShortDateString() == fecha2 && c.Hora_Inicio == time12)
                {
                    day3 = "Cita con " + c.Correo;
                }
                if (c.Fecha.ToShortDateString() == fecha3 && c.Hora_Inicio == time12)
                {
                    day4 = "Cita con " + c.Correo;
                }
                if (c.Fecha.ToShortDateString() == fecha4 && c.Hora_Inicio == time12)
                {
                    day5 = "Cita con " + c.Correo;
                }
                if (c.Fecha.ToShortDateString() == fecha5 && c.Hora_Inicio == time12)
                {
                    day6 = "Cita con " + c.Correo;
                }
                if (c.Fecha.ToShortDateString() == fecha6 && c.Hora_Inicio == time12)
                {
                    day7 = "Cita con " + c.Correo;
                }
            }

            semana h12 = new semana(day1, day2, day3, day4, day5, day6, day7, mes);

            //CREANDO H1
            day1 = "Disponible";
            day2 = "Disponible";
            day3 = "Disponible";
            day4 = "Disponible";
            day5 = "Disponible";
            day6 = "Disponible";
            day7 = "Disponible";
            mes = "1:00 PM";

            foreach (var c in cita)
            {
                if (c.Fecha.ToShortDateString() == fecha && c.Hora_Inicio == time1)
                {
                    day1 = "Cita con " + c.Correo;
                }
                if (c.Fecha.ToShortDateString() == fecha1 && c.Hora_Inicio == time1)
                {
                    day2 = "Cita con " + c.Correo;
                }
                if (c.Fecha.ToShortDateString() == fecha2 && c.Hora_Inicio == time1)
                {
                    day3 = "Cita con " + c.Correo;
                }
                if (c.Fecha.ToShortDateString() == fecha3 && c.Hora_Inicio == time1)
                {
                    day4 = "Cita con " + c.Correo;
                }
                if (c.Fecha.ToShortDateString() == fecha4 && c.Hora_Inicio == time1)
                {
                    day5 = "Cita con " + c.Correo;
                }
                if (c.Fecha.ToShortDateString() == fecha5 && c.Hora_Inicio == time1)
                {
                    day6 = "Cita con " + c.Correo;
                }
                if (c.Fecha.ToShortDateString() == fecha6 && c.Hora_Inicio == time1)
                {
                    day7 = "Cita con " + c.Correo;
                }
            }

            semana h1 = new semana(day1, day2, day3, day4, day5, day6, day7, mes);

            //CREANDO H2
            day1 = "Disponible";
            day2 = "Disponible";
            day3 = "Disponible";
            day4 = "Disponible";
            day5 = "Disponible";
            day6 = "Disponible";
            day7 = "Disponible";
            mes = "2:00 PM";

            foreach (var c in cita)
            {
                if (c.Fecha.ToShortDateString() == fecha && c.Hora_Inicio == time2)
                {
                    day1 = "Cita con " + c.Correo;
                }
                if (c.Fecha.ToShortDateString() == fecha1 && c.Hora_Inicio == time2)
                {
                    day2 = "Cita con " + c.Correo;
                }
                if (c.Fecha.ToShortDateString() == fecha2 && c.Hora_Inicio == time2)
                {
                    day3 = "Cita con " + c.Correo;
                }
                if (c.Fecha.ToShortDateString() == fecha3 && c.Hora_Inicio == time2)
                {
                    day4 = "Cita con " + c.Correo;
                }
                if (c.Fecha.ToShortDateString() == fecha4 && c.Hora_Inicio == time2)
                {
                    day5 = "Cita con " + c.Correo;
                }
                if (c.Fecha.ToShortDateString() == fecha5 && c.Hora_Inicio == time2)
                {
                    day6 = "Cita con " + c.Correo;
                }
                if (c.Fecha.ToShortDateString() == fecha6 && c.Hora_Inicio == time2)
                {
                    day7 = "Cita con " + c.Correo;
                }
            }

            semana h2 = new semana(day1, day2, day3, day4, day5, day6, day7, mes);

            //CREANDO H3
            day1 = "Disponible";
            day2 = "Disponible";
            day3 = "Disponible";
            day4 = "Disponible";
            day5 = "Disponible";
            day6 = "Disponible";
            day7 = "Disponible";
            mes = "3:00 PM";

            foreach (var c in cita)
            {
                if (c.Fecha.ToShortDateString() == fecha && c.Hora_Inicio == time3)
                {
                    day1 = "Cita con " + c.Correo;
                }
                if (c.Fecha.ToShortDateString() == fecha1 && c.Hora_Inicio == time3)
                {
                    day2 = "Cita con " + c.Correo;
                }
                if (c.Fecha.ToShortDateString() == fecha2 && c.Hora_Inicio == time3)
                {
                    day3 = "Cita con " + c.Correo;
                }
                if (c.Fecha.ToShortDateString() == fecha3 && c.Hora_Inicio == time3)
                {
                    day4 = "Cita con " + c.Correo;
                }
                if (c.Fecha.ToShortDateString() == fecha4 && c.Hora_Inicio == time3)
                {
                    day5 = "Cita con " + c.Correo;
                }
                if (c.Fecha.ToShortDateString() == fecha5 && c.Hora_Inicio == time3)
                {
                    day6 = "Cita con " + c.Correo;
                }
                if (c.Fecha.ToShortDateString() == fecha6 && c.Hora_Inicio == time3)
                {
                    day7 = "Cita con " + c.Correo;
                }
            }

            semana h3 = new semana(day1, day2, day3, day4, day5, day6, day7, mes);

            //CREANDO H4
            day1 = "Disponible";
            day2 = "Disponible";
            day3 = "Disponible";
            day4 = "Disponible";
            day5 = "Disponible";
            day6 = "Disponible";
            day7 = "Disponible";
            mes = "4:00 PM";

            foreach (var c in cita)
            {
                if (c.Fecha.ToShortDateString() == fecha && c.Hora_Inicio == time4)
                {
                    day1 = "Cita con " + c.Correo;
                }
                if (c.Fecha.ToShortDateString() == fecha1 && c.Hora_Inicio == time4)
                {
                    day2 = "Cita con " + c.Correo;
                }
                if (c.Fecha.ToShortDateString() == fecha2 && c.Hora_Inicio == time4)
                {
                    day3 = "Cita con " + c.Correo;
                }
                if (c.Fecha.ToShortDateString() == fecha3 && c.Hora_Inicio == time4)
                {
                    day4 = "Cita con " + c.Correo;
                }
                if (c.Fecha.ToShortDateString() == fecha4 && c.Hora_Inicio == time4)
                {
                    day5 = "Cita con " + c.Correo;
                }
                if (c.Fecha.ToShortDateString() == fecha5 && c.Hora_Inicio == time4)
                {
                    day6 = "Cita con " + c.Correo;
                }
                if (c.Fecha.ToShortDateString() == fecha6 && c.Hora_Inicio == time4)
                {
                    day7 = "Cita con " + c.Correo;
                }
            }

            semana h4 = new semana(day1, day2, day3, day4, day5, day6, day7, mes);


            SemanaCitas horario = new SemanaCitas(titulo, h9, h10, h11, h12, h1, h2, h3, h4);
            return View(horario);
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
                string mensaje = repoCita.SaveCita(cita);
                TempData["message"] = string.Format(mensaje);
                return RedirectPermanent("Citas");
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