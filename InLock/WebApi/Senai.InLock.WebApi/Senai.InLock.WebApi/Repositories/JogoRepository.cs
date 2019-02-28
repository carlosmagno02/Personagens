using Senai.InLock.WebApi.Domains;
using Senai.InLock.WebApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.InLock.WebApi.Repositories
{
    public class JogoRepository : IJogoRepository
    {
        private string StringConexao = "Data Source=.\\SqlExpress; initial catalog=InLock_Games_Manha;user id=sa;pwd=132";
        public void Cadastrar(JogoDomain Jogo)
        {
            string QueryInsert = @"INSERT JOGOS(NOME, DESCRICAO, DATALANCAMENTO, VALOR, ESTUDIOID)
VALUES(@NOME, @DESCRICAO, @DATALANCAMENTO, @VALOR, @ESTUDIOID)";

            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                con.Open();

                SqlCommand cmd = new SqlCommand(QueryInsert, con);
                cmd.Parameters.AddWithValue("@NOME", Jogo.Nome);
                cmd.Parameters.AddWithValue("@DESCRICAO", Jogo.Descricao);
                cmd.Parameters.AddWithValue("@DATALANCAMENTO", Jogo.DataLancamento);
                cmd.Parameters.AddWithValue("@VALOR", Jogo.Valor);
                cmd.Parameters.AddWithValue("@ESTUDIOID", Jogo.EstudioId);


                cmd.ExecuteNonQuery();
            }
        }

        public List<JogoDomain> Listar()
        {
            string QuerySelect = "SELECT ID, NOME, DESCRICAO, DATALANCAMENTO, VALOR, ESTUDIOID FROM INSTITUICOES";

            List<JogoDomain> ListaJogos = new List<JogoDomain>();

            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                con.Open();

                SqlDataReader sdr;

                using (SqlCommand cmd = new SqlCommand(QuerySelect, con))
                {
                    sdr = cmd.ExecuteReader();

                    while (sdr.Read())
                    {
                        JogoDomain instituicao = new JogoDomain
                        {
                            ID = Convert.ToInt32(sdr["ID"])
                            ,
                            Nome = sdr["NOME"].ToString()
                            ,
                            Descricao = sdr["DESCRICAO"].ToString()
                            ,
                            DataLancamento = Convert.ToDateTime(sdr["DATALANCAMENTO"])
                            ,
                            Valor = Convert.ToDecimal(sdr["VALOR"])
                            ,
                            EstudioId = Convert.ToInt32(sdr["ESTUDIOID"])
 
                        };

                        ListaJogos.Add(jogo);
                    }
                }
            }

            return ListaJogos;

        }
    }
}
