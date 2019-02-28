using Senai.InLock.WebApi.Domains;
using Senai.InLock.WebApi.Interfaces;
using System;
using System.Data.SqlClient;

namespace Senai.InLock.WebApi.Repositories
{
    public class LoginRepository : ILoginRepository
    {
        private string StringConexao = "Data Source=.\\SqlExpress; initial catalog=InLock_Games_Manha;user id=sa;pwd=132";

        public LoginDomain BuscarPorEmailSenha(string email, string senha)
        {
            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                string  QuerySelect = "SELECT ID, NOME, EMAIL, SENHA, TIPO_USUARIO FROM USUARIOS WHERE EMAIL = @EMAIL AND SENHA =@SENHA";
                using(SqlCommand cmd = new SqlCommand(QuerySelect, con))
                {
                    cmd.Parameters.AddWithValue("@EMAIL", email);
                    cmd.Parameters.AddWithValue("@SENHA", senha);

                    con.Open();

                    SqlDataReader sdr = cmd.ExecuteReader();

                    if (sdr.HasRows)
                    {
                        LoginDomain login = new LoginDomain();
                        
                        while (sdr.Read())
                        {
                            login.ID = Convert.ToInt32(sdr["ID"]);
                            login.Email = sdr["EMAIL"].ToString();
                            login.TipoUsuario = sdr["TIPO_USUARIO"].ToString();
                        }
                        return login;
                    }
                }
                return null;
            }
        }

        public void Cadastrar(LoginDomain login)
        {
            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                string QueryInsert  = "INSERT INTO USUARIOS(EMAIL,SENHA,TIPO_USUARIO) VALUES (@EMAIL,@SENHA,@TIPO_USUARIO)";

                using (SqlCommand cmd = new SqlCommand(QueryInsert, con))
                {
                    cmd.Parameters.AddWithValue("@EMAIL", login.Email);
                    cmd.Parameters.AddWithValue("@SENHA", login.Senha);
                    cmd.Parameters.AddWithValue("@TIPO_USUARIO", login.TipoUsuario);

                    con.Open();

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
