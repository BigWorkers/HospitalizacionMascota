using Microsoft.EntityFrameworkCore;
using HomePetCare.App.Dominio;

namespace HomePetCare.App.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet <Persona> Personas {get;set;}
        public DbSet <Mascota> Mascotas {get;set;}
        public DbSet <PropietarioMascota> PropietarioMascotas {get;set;}
        public DbSet <ReporteVisita> ReportesVisitas {get;set;}
        public DbSet <VeterinarioDomiciliario> VeterinariosDomiciliarios {get;set;}
        public DbSet <Historia> Historias {get;set;}
        public DbSet <Formula> Formulas {get;set;}
        
protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
             optionsBuilder
            .UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = HomePetCare.Data");
        }
    }
    }
 
}
