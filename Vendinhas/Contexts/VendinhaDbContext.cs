using Microsoft.EntityFrameworkCore;
using Vendinhas.Models;
using System;

namespace Vendinhas.Contexts
{
    public class VendinhaDbContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }

        public DbSet<Divida> Dividas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string? connectionString = Environment.GetEnvironmentVariable("VENDINHAS_CONNECTION");

            if (string.IsNullOrWhiteSpace(connectionString))
            {
                throw new InvalidOperationException(
                    "A variável VENDINHAS_CONNECTION não foi configurada.");
            }

            optionsBuilder.UseNpgsql(connectionString);
        }
    }
}
