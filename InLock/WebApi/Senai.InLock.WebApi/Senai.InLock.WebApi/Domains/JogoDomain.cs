using System;
using System.ComponentModel.DataAnnotations;

namespace Senai.InLock.WebApi.Domains
{
    public class JogoDomain
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Informe o Nome do jogo")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Informe a descrição do jogo")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Informe a data de lançamento")]
        public DateTime DataLancamento { get; set; }

        [Required(ErrorMessage = "Informe o preço do jogo")]
        public Decimal Valor { get; set; }

        public int EstudioId { get; set; }
    }
}
