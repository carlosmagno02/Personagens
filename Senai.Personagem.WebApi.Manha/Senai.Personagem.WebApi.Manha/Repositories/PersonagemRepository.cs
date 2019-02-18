using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Senai.Personagem.WebApi.Manha.Domains;
using Senai.Personagem.WebApi.Manha.Interfaces;

namespace Senai.Personagem.WebApi.Manha.Repositories
{
    public class PersonagemRepository : IPersonagemRepository
    {
        private string StringConexao = "Data Source=.\\SqlExpress; initial catalog=SENAI_PERSONAGEM_MANHA;user id=sa;pwd=132";

        public void Alterar(PersonagemDomain instituicao, int id)
        {
            throw new System.NotImplementedException();
        }

        public PersonagemDomain BuscarPorId(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Cadastrar(PersonagemDomain instituicao)
        {
            throw new System.NotImplementedException();
        }

        public void Deletar(int Id)
        {
            throw new System.NotImplementedException();
        }

        public List<PersonagemDomain> Listar()
        {
            string QuerySelect = "SELECT ID, NOME, LANCAMENTO FROM PERSONAGENS";

            List<PersonagemDomain> ListaPersonagens = new List<PersonagemDomain>();
            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                con.Open();

                SqlDataReader sdr;

                using (SqlCommand cmd = new SqlCommand(QuerySelect, con))
                {
                    sdr = cmd.ExecuteReader();

                    while (sdr.Read())
                    {
                        PersonagemDomain personagem = new PersonagemDomain
                        {
                            Id = Convert.ToInt32(sdr["ID"])
                            ,
                            Nome = sdr["NOME_FANTASIA"].ToString()
                            ,
                            Lancamento = sdr["RAZAO_SOCIAL"].ToString()

                        };
                        ListaPersonagens.Add(personagem);
                    }
                }
            }
            return ListaPersonagens;
        }
    }
}
