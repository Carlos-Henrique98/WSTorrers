using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WSTorrer.Domains;

namespace WSTorrer.Interface
{
    interface IJogadorRepository
    {
        List<Jogador> Listar();
    }
}
