using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WSTower.Contexts;
using WSTower.Domains;

namespace WSTower.Repositories
{
    public class PrincipalRepository
    {
        CampeonatoBDContext ctx = new CampeonatoBDContext();

        public Selecao buscarSelecao(string sele)
        {
            Selecao selecaoInfo = ctx.Selecao.Select(s => new Selecao()
            {
                Id = s.Id,
                Nome = s.Nome,
                Bandeira = s.Bandeira,
                Uniforme = s.Uniforme,
                Escalacao = s.Escalacao,
            }).FirstOrDefault(s => s.Nome.Contains(sele));

            return selecaoInfo;
        }
    }
}
