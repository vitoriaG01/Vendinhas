using System;
using System.Collections.Generic;
using System.Linq;
using Vendinhas.Models;
using Vendinhas.Contexts;

namespace Vendinhas.Services
{
    public class DividaService
    {
        public List<Divida> ListarDividas(int clienteId)
        {
            using (var banco = new VendinhaDbContext())
            {
                return banco.Dividas
                    .Where(d => d.ClientId == clienteId)
                    .ToList();
            }
        }

        public bool CadastrarDivida(Divida divida)
        {
            using (var banco = new VendinhaDbContext())
            {
                bool existeDivida = banco.Dividas.Any(d => d.ClientId == divida.ClientId && d.Paga == false);

                if (existeDivida)
                {
                    return false;
                }

                divida.DataCriacao = DateTime.UtcNow;
                divida.Paga = false;
                divida.DataPagamento = null;

                banco.Dividas.Add(divida);
                banco.SaveChanges();

                return true;
            }
        }

        public bool PagarDivida(int id)
        {
            using (var banco = new VendinhaDbContext())
            {
                var divida = banco.Dividas.FirstOrDefault(d => d.Id == id);

                if (divida == null)
                {
                    return false;
                }

                if (divida.Paga)
                {
                    return false;
                }

                divida.Paga = true;
                divida.DataPagamento = DateTime.UtcNow;

                banco.SaveChanges();

                return true;
            }
        }
    }
}
