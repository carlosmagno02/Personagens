using Senai.InLock.CodeFirst.WebApi.Manha.Domains;
using System.Collections.Generic;

namespace Senai.InLock.CodeFirst.WebApi.Manha.Interfaces
{
    interface IJogoRepository
    {
        List<JogoDomain> Listar();

        void Cadastrar(JogoDomain jogo);

        void Alterar(JogoDomain jogo);

        void Excluir(int id);
    }
}
