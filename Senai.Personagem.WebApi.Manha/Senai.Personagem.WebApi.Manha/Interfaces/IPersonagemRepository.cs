using Senai.Personagem.WebApi.Manha.Domains;
using System.Collections.Generic;

namespace Senai.Personagem.WebApi.Manha.Interfaces
{
    interface IPersonagemRepository
    {
        List<PersonagemDomain> Listar();

        PersonagemDomain BuscarPorId(int id);

        void Cadastrar(PersonagemDomain instituicao);

        void Alterar(PersonagemDomain instituicao, int id);

        void Deletar(int Id);
    }
}


