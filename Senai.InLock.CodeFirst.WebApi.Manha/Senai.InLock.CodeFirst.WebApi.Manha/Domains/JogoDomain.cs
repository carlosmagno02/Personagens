using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.InLock.CodeFirst.WebApi.Manha.Domains
{
    public class JogoDomain
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int JogoId { get; set; }

        [Column( TypeName = "varchar(150)")]
        [Required]
        public string NomeJogo { get; set; }

        [Column(TypeName = "Text")]
        [Required]
        public string Descricao { get; set; }

        [DataType(DataType.Currency)]
        [Required]
        public DateTime DataLancamento { get; set; }

        public Decimal Valor { get; set; }

        public int EstudioId { get; set; }

        [ForeignKey("EstudioId")]
        public EstudioDomain Estudio { get; set; }
    }
}
