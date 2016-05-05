using System.Collections.Generic;
using Horario.Domain.Entities;


namespace Horario.Domain.Abstract
{
    public interface ICarreraRepository
    {
        IEnumerable<Carrera> Carreras { get; }
        void SaveCarrera(Carrera carrera);
        Carrera DeleteCarrera(string ID);
    }
}

