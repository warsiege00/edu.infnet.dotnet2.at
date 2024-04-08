using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace InfnetMVC.Data
{
    public class InfnetDbContext : IdentityDbContext<IdentityUser>
    {
        public InfnetDbContext(DbContextOptions<InfnetDbContext> options)
            : base(options)
        {
        }

        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Departamento> Departamentos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=infnet.db");
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Configuração da tabela Funcionarios
            modelBuilder.Entity<Funcionario>().HasData(
                new Funcionario { Id = 1, Nome = "João", Endereco = "Rua A", Telefone = "123456789", Email = "joao@example.com", DataNascimento = new DateTime(1990, 1, 1), DepartamentoId = 1 },
                new Funcionario { Id = 2, Nome = "Maria", Endereco = "Rua B", Telefone = "987654321", Email = "maria@example.com", DataNascimento = new DateTime(1980, 5, 10), DepartamentoId = 2 }
            );

            // Configuração da tabela Departamentos
            modelBuilder.Entity<Departamento>().HasData(
                new Departamento { Id = 1, Nome = "TI", Local = "Andar 1" },
                new Departamento { Id = 2, Nome = "RH", Local = "Andar 2" }
            );
        }
        
    }
}
