using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Threading.Tasks;
using WSTower.Contexts;
using WSTower.Domains;

namespace WSTowers.Repositories
{
    public class JogadorRepository
    {
        CampeonatoBDContext ctx = new CampeonatoBDContext();

        public List<Jogador> ListarInner()
        {
            return ctx.Jogador.Include(x => x.Selecao).ToList();
        }

        public Jogador buscarJogador(string info)
        {
            Jogador jogadorInfo = ctx.Jogador.Select(j => new Jogador()
            {
                Id = j.Id,
                Foto = j.Foto,
                Posicao = j.Posicao,
                Nome = j.Nome,
                Nascimento = j.Nascimento,
                NumeroCamisa = j.NumeroCamisa,
                Qtdegols = j.Qtdegols,
                QtdecartoesAmarelo = j.QtdecartoesAmarelo,
                QtdecartoesVermelho = j.QtdecartoesVermelho,
                Qtdefaltas = j.Qtdefaltas,
                Informacoes = j.Informacoes,
                SelecaoId = j.SelecaoId,

                Selecao = new Selecao()
                {
                    Bandeira = j.Selecao.Bandeira,
                    Nome = j.Selecao.Nome
                }

            }).FirstOrDefault(j => j.Nome.Contains(info));

        
            return jogadorInfo;
        }

        public List<Jogador> buscarPorSelecao(string selecao)
        {
            using (CampeonatoBDContext ctx = new CampeonatoBDContext())
            {                    
                return ctx.Jogador.Where(x => x.Selecao.Nome.Contains(selecao)).ToList();
            }
        }
    }
}

