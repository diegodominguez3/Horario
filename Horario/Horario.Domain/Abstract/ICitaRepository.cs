using System.Collections.Generic;
using Horario.Domain.Entities;


namespace Horario.Domain.Abstract
{
    public interface ICitaRepository
    {
        IEnumerable<Cita> Citas { get; }
        void SaveCita(Cita cita);
        Cita DeleteCita(string ID);
    }
}

