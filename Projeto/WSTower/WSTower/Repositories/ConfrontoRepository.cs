using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WSTower.Contexts;
using WSTower.Domains;

namespace WSTower.Repositories
{
    public class ConfrontoRepository
    {
        CampeonatoBDContext ctx = new CampeonatoBDContext();

        public Selecao confrontoJogos(string jogo)
        {
            Selecao selecaoConfr = ctx.Selecao.Select(c => new Selecao()
            {
                Id = c.Id,
                Nome = c.Nome,
                Jogador = c.Jogador,
                Bandeira = c.Bandeira,
                Uniforme = c.Uniforme,
                Escalacao = c.Escalacao
            }).FirstOrDefault(c => c.Nome.Contains(jogo));

            return selecaoConfr;
        }
    }
}
