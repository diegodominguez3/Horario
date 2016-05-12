using System.Collections.Generic;
using Horario.Domain.Entities;


namespace Horario.Domain.Abstract
{
    public interface ICitaRepository
    {
        IEnumerable<Cita> Citas { get; }
        List<Cita> Exist(); 
        string SaveCita(Cita cita); 
        Cita DeleteCita(int ID);
    }
}

