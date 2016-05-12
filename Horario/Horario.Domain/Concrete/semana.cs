using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Horario.Domain.Concrete
{
    public class semana
    {
        public string Dia1 { get; set; }
        public string Dia2 { get; set; }
        public string Dia3 { get; set; }
        public string Dia4 { get; set; }
        public string Dia5 { get; set; }
        public string Dia6 { get; set; }
        public string Dia7 { get; set; }
        public string Mes { get; set; }
        public semana(string dia1, string dia2, string dia3, string dia4, string dia5, string dia6, string dia7, string mes)
        {
            Dia1 = dia1;
            Dia2 = dia2;
            Dia3 = dia3;
            Dia4 = dia4;
            Dia5 = dia5;
            Dia6 = dia6;
            Dia7 = dia7;
            Mes = mes;
        }
        /*public semana GetDays()
    {

        DateTime date = DateTime.Now;
        DateTime date1 = date.AddDays(1);
        DateTime date2 = date.AddDays(2);
        DateTime date3 = date.AddDays(3);
        DateTime date4 = date.AddDays(4);
        DateTime date5 = date.AddDays(5);
        DateTime date6 = date.AddDays(6);

        string day1 = date.DayOfWeek.ToString() + " " + date.Day.ToString();
        string day2 = date.DayOfWeek.ToString() + " " + date.Day.ToString();
        string day3 = date.DayOfWeek.ToString() + " " + date.Day.ToString();
        string day4 = date.DayOfWeek.ToString() + " " + date.Day.ToString();
        string day5 = date.DayOfWeek.ToString() + " " + date.Day.ToString();
        string day6 = date.DayOfWeek.ToString() + " " + date.Day.ToString();
        string day7 = date.DayOfWeek.ToString() + " " + date.Day.ToString();
        string mes = date.Month.ToString() + " " + date.Year.ToString();

        semana semana = new semana(day1, day2, day3, day4, day5, day6, day7, mes);
        return semana;
    }*/
    }

}
