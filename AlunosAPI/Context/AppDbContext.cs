using Microsoft.EntityFrameworkCore;
using AlunosAPI.Models;

namespace AlunosAPI.Context{
    public class AppDbContext : DbContext{
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Aluno> Alunos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Aluno>().HasData(
                new Aluno { Id = 1, Name = "João Silva", Email = "joao.silva@example.com", Idade = 20 },
                new Aluno { Id = 2, Name = "Maria Oliveira", Email = "mariaoliveira@gmail.com", Idade = 22 }
            );
        }
    }
}