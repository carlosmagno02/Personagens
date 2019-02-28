using Senai.InLock.CodeFirst.WebApi.Manha.Context;
using Senai.InLock.CodeFirst.WebApi.Manha.Domains;
using Senai.InLock.CodeFirst.WebApi.Manha.Interfaces;
using Senai.InLock.CodeFirst.WebApi.Manha.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.InLock.CodeFirst.WebApi.Manha.Repositories
{
    public class JogoRepository : IJogoRepository
    {
        public void Alterar(JogoDomain jogo)
        {
            using (InLockContext ctx = new InLockContext())
            {
                ctx.Jogos.Update(jogo);
                ctx.SaveChanges();
            };
        }

        public void Cadastrar(JogoDomain jogo)
        {
            using (InLockContext ctx = new InLockContext())
            {
                ctx.Jogos.Add(jogo);
                ctx.SaveChanges();
            }

        }

        public void Excluir(int id)
        {
            using (InLockContext ctx = new InLockContext())
            {
                
                ctx.SaveChanges();

            }


        }

        public List<JogoDomain> Listar()
        {
            using (InLockContext ctx = new InLockContext())
            {
                return ctx.Jogos.ToList();
            }
        }
    }
}
