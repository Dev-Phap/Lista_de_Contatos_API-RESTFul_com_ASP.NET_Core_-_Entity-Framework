using Microsoft.EntityFrameworkCore;
using APIEstudoEFCore.Entities;



namespace APIEstudoEFCore.Contexts



{
    public class AgendaContext : DbContext
    {

        public AgendaContext(DbContextOptions<AgendaContext> options) : base(options) { }



        public DbSet<Contato> Contatos { get; set; }
    }
}
