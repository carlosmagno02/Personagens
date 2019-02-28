using SenaiInLockDataBase.Domains;
using System.Collections.Generic;

namespace SenaiInLockDataBase.Interfaces
{
    interface IJogoRepository
    {
        List<Jogos> Listar();

        void Cadastrar(Jogos jogos);
    }
}
