using System;

namespace Senai.Senatur.WebApi.Domains
{
    public partial class Pacotes
    {
        public int Pacoteid { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public DateTime DataIda { get; set; }
        public DateTime DataVolta { get; set; }
        public decimal Valor { get; set; }
        public string Cidade { get; set; }
        public string Ativo { get; set; }
    }
}
