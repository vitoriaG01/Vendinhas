using System.Collections.Generic;
using System.Linq;
using Vendinhas.Models;
using Vendinhas.Contexts;


namespace Vendinhas.Services
{
    public class ClienteService
    {
        public List<Cliente> ListarClientes()
        {
            using (var banco = new VendinhaDbContext())
            {
                var clientes = banco.Clientes.ToList();

                foreach (var cliente in clientes)
                {
                    cliente.TotalDividas = banco.Dividas
                        .Where(d => d.ClientId == cliente.Id && d.Paga == false)
                        .Sum(d => (decimal?)d.Valor) ?? 0;
                }

                return clientes;
            }
        }

        public Cliente? BuscarCliente(int id)
        {
            using (var banco = new VendinhaDbContext())
            {
                return banco.Clientes.FirstOrDefault(c => c.Id == id);
            }
        }

        public bool CadastrarCliente(Cliente cliente)
        {
            using (var banco = new VendinhaDbContext())
            {
                bool existe = banco.Clientes.Any(c => c.CPF == cliente.CPF);

                if (existe)
                {
                    return false;
                }

                banco.Clientes.Add(cliente);
                banco.SaveChanges();

                return true;
            }
        }

        public bool AtualizarCliente(Cliente cliente)
        {
            using (var banco = new VendinhaDbContext())
            {
                bool existe = banco.Clientes.Any(c => c.CPF == cliente.CPF && c.Id != cliente.Id);

                if (existe)
                {
                    return false;
                }

                var clienteBanco = banco.Clientes.FirstOrDefault(c => c.Id == cliente.Id);

                if (clienteBanco == null)
                {
                    return false;
                }

                clienteBanco.NomeCompleto = cliente.NomeCompleto;
                clienteBanco.CPF = cliente.CPF;
                clienteBanco.DataNascimento = cliente.DataNascimento;
                clienteBanco.Email = cliente.Email;

                banco.SaveChanges();

                return true;
            }
        }

        public bool ExcluirCliente(int id)
        {
            using (var banco = new VendinhaDbContext())
            {
                var cliente = banco.Clientes.FirstOrDefault(c => c.Id == id);

                if (cliente == null)
                {
                    return false;
                }

                banco.Clientes.Remove(cliente);
                banco.SaveChanges();

                return true;
            }
        }
    }
}