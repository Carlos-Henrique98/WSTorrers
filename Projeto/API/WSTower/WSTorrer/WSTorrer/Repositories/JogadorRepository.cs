using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WSTorrer.Contexts;
using WSTorrer.Domains;
using WSTorrer.Interface;

namespace WSTorrer.Repositories
{
    public class JogadorRepository : IJogadorRepository
    {
        CampeonatoContext jog = new CampeonatoContext();

        public List<Jogador> Listar()
        {
            return jog.Jogador.ToList();
        }

  
    }
}
