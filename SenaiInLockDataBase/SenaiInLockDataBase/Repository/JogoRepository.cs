using SenaiInLockDataBase.Domains;
using SenaiInLockDataBase.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace SenaiInLockDataBase.Repository
{
    public class JogoRepository : IJogoRepository
    {
        public void Cadastrar(Jogos jogos)
        {
            using (InLockContext ctx = new InLockContext()) 
            {
                ctx.Jogos.Add(jogos);
                ctx.SaveChanges();
            }
        }

        public List<Jogos> Listar()
        {
            using(InLockContext ctx = new InLockContext())
            {
                return ctx.Jogos.ToList();
            }

        }
    }
}
