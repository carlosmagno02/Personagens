using Senai.InLock.WebApi.Domains;

namespace Senai.InLock.WebApi.Interfaces
{
    interface ILoginRepository
    {
        void Cadastrar(LoginDomain login);
        LoginDomain BuscarPorEmailSenha(string email, string senha);


    }
}
