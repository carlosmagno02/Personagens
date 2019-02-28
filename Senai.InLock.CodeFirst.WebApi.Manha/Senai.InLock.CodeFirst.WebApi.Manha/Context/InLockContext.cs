using Microsoft.EntityFrameworkCore;
using Senai.InLock.CodeFirst.WebApi.Manha.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.InLock.CodeFirst.WebApi.Manha.Context
{
    public class InLockContext : DbContext
    {
        public DbSet<JogoDomain> Jogos { get; set; }

        public DbSet<EstudioDomain> Estudios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuild)
        {
            optionsBuild.UseSqlServer("Data Source=.\\SqlExpress; initial catalog=SENAI_INLOCK_CODE_FIRST;user id=sa;pwd=132");
            base.OnConfiguring(optionsBuild);
        }
    }
}
