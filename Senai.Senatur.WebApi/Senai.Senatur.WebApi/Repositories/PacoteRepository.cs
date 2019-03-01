using Senai.Senatur.WebApi.Domains;
using Senai.Senatur.WebApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Senatur.WebApi.Repositories
{
    public class PacoteRepository : IPacoteRepository
    {
        public void Atualizar(Pacotes pacotes)
        {
            using (SENATURContext ctx = new SENATURContext())
            {
                ctx.Pacotes.Update(pacotes);
                ctx.SaveChanges();
            }
        }

        public void Cadastrar(Pacotes pacotes)
        {
            using (SENATURContext ctx = new SENATURContext())
            {
                ctx.Pacotes.Add(pacotes);
                ctx.SaveChanges();
            }
        }

        public List<Pacotes> Listar()
        {
            using (SENATURContext ctx = new SENATURContext())
            {
                return ctx.Pacotes.ToList();
            }
        }
    }
}
