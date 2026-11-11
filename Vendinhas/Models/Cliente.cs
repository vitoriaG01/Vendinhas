using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vendinhas.Models
{
    public class Cliente
    {
        public int Id { get; set; }

        public string NomeCompleto { get; set; } = "";

        public string CPF { get; set; } = "";

        public DateTime DataNascimento { get; set; }

        public string Email { get; set; } = "";

        [NotMapped]
        public decimal TotalDividas { get; set; }

        public int Idade
        {
            get
            {
                int idade = DateTime.Now.Year - DataNascimento.Year;

                if (DateTime.Now < DataNascimento.AddYears(idade))
                {
                    idade--;
                }

                return idade;
            }
        }
    }
}
