using System;
using System.Data;


namespace Vendinhas.Models
{
    public class Divida
    {
        public int Id { get; set; }

        public int ClientId { get; set; }

        public decimal Valor { get; set; }

        public bool Paga { get; set; }

        public DateTime DataCriacao { get; set; }

        public DateTime? DataPagamento { get; set; }
    }
}
