using System.Collections.Generic;
using Horario.Domain.Entities;


namespace Horario.Domain.Abstract
{
    public interface IPersonaRepository
    {
        IEnumerable<Persona> Personas { get; }
        void SavePersona(Persona persona);
        Persona DeletePersona(string ID);
    }
}

