using Microsoft.AspNetCore.Mvc;
using Senai.InLock.WebApi.Domains;
using Senai.InLock.WebApi.Interfaces;
using Senai.InLock.WebApi.Repositories;

namespace Senai.InLock.WebApi.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private ILoginRepository LoginRepository { get; set; }

        public LoginController()
        {
            LoginRepository = new LoginRepository();
        }

        /// <summary>
        /// Cadastra um novo usuário
        /// </summary>
        /// <param name="usuario">UsuarioDomain</param>
        /// <returns>Retorna um Status Code</returns>
        [HttpPost]
        public IActionResult Post(LoginDomain usuario)
        {
            try
            {
                //Chama o repositorio para efetuar o cadastro do usuário
                LoginRepository.Cadastrar(usuario);

                //Retorna um status code 200 informando que o usuário foi cadastrado
                return Ok(new
                {
                    mensagem = "Usuário Cadastrado"
                });
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}