using apicliente.Models;
using Microsoft.EntityFrameworkCore;

namespace apicliente.Context
{
    public class AppDBContext : DbContext
    {

        protected readonly IConfiguration Configuration;

        public AppDBContext(IConfiguration configuration)
        {
            Configuration = configuration;

        }


        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to sqlite database
            options.UseSqlite(Configuration.GetConnectionString("WebApiDB"));
        }

        public DbSet<Clientes> Clientes { get; set; }
    }
}
