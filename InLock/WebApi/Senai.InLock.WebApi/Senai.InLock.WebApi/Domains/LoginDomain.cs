using System.ComponentModel.DataAnnotations;

namespace Senai.InLock.WebApi.Domains
{
    /// <summary>
    /// Classe que representa a tabela USUARIOS no banco de dados
    /// </summary>
    public class LoginDomain
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Informe o email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Informe a senha")]
        public string Senha { get; set; }

        [Required(ErrorMessage = "Informe o tipo de usuario")]
        public string TipoUsuario { get; set; }
    }
}
