using Senai.Senatur.WebApi.Domains;
using System.Collections.Generic;

namespace Senai.Senatur.WebApi.Interfaces
{
    interface IPacoteRepository
    {
        List<Pacotes> Listar();

        void Cadastrar(Pacotes pacotes);

        void Atualizar(Pacotes pacotes);

    }
}
