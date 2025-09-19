using Microsoft.EntityFrameworkCore;
using projetoapi.Models;

namespace projetoapi.Context
{
    public class RHContext : DbContext
    {
        //Construtor
        public RHContext(DbContextOptions<RHContext> options) : base(options)
        {

        }
        //Tabela Funcionarios
        public DbSet<Funcionario> Funcionarios { get; set; }
    }

   
}