using System.Collections.Generic;
using Horario.Domain.Entities;


namespace Horario.Domain.Abstract
{
    public interface IDicaRepository
    {
        IEnumerable<Dica> Dicas { get; }
        void SaveDica(Dica dica);
        Dica DeleteDica(string nomina);
    }
}

