using System.ComponentModel.DataAnnotations;

namespace Senai.InLock.WebApi.Domains
{
    public class EstudioDomain
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Informe o nome do estudio")]
        public string Nome { get; set; }
    }
}
