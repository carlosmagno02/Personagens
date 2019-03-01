using SenaiInLockDataBase.Domains;
using SenaiInLockDataBase.Interfaces;
using System.Collections.Generic;
using System.Linq;

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
