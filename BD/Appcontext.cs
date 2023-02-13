
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Praktica
{
    public class ApplicationContext : DbContext
    {

    
        public DbSet<Otdel>? Otdels { get; set; }
        public DbSet<Sotrudnik>? Sotrudniks { get; internal set; }
        public DbSet<Prikaz>? Prikazs { get; internal set; }
        public DbSet<Komandirovka>? Komandirovkas { get; internal set; }
        public DbSet<Otpusk>? Otpusks { get; internal set; }
        public DbSet<Uvolnenie>? Uvolnenies { get; internal set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder();
            builder.SetBasePath(Directory.GetCurrentDirectory());
            builder.AddJsonFile("json1.json");
            var config = builder.Build();
            string connectionString = config.GetConnectionString("DefaultConnection");

            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}

