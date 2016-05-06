using System.Collections.Generic;

namespace Horario.Domain.Abstract
{
    public interface IHorarioRepository
    {
        IEnumerable<Horario.Domain.Entities.Horario> Horarios { get; }
        void SaveHorario(Horario.Domain.Entities.Horario horario);
        Horario.Domain.Entities.Horario DeleteHorario(string ID);
    }
}