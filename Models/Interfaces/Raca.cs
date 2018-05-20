using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarabotaBotsProjeto.Models.Interfaces
{
    interface Raca
    {
        string Nome { get; }
        string CaracteristicasFisicas { get; }
        string CaracteristicasComportamentais { get; }
        string Problemas { get; }
        string Cuidados { get; }
        List<string> Imagens { get; }
        string Origem { get; }
        string PaisDeOrigem { get; }
        List<string> Curiosidades { get; }
    }
}
