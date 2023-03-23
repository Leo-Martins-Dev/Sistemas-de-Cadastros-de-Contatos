using Controle_de_cadastros.Models;
using Microsoft.EntityFrameworkCore;

namespace Controle_de_cadastros.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options) 
        { 
        }

        public DbSet<ContatoModel> Contatos { get; set; }
    }
}
