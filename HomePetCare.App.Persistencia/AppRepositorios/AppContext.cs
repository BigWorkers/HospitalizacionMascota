using Microsoft.EntityFrameworkCore;
using HomePetCare.App.Dominio;
using System;

namespace HomePetCare.App.Persistencia

{
    public class AppContext : DbContext
    {
        public DbSet<Formula> Formulas { get; set; }
        public DbSet<Mascota> Mascotas { get; set; }
        public DbSet<PropietarioMascota> PropietariosMascotas { get; set; }
        public DbSet<ReporteVisita> ReportesVisitas { get; set; }
        public DbSet<Recomendaciones> Recomendacion { get; set; }
        public DbSet<VeterinarioDomiciliario> VeterinariosDomiciliarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                .UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = HomePetCareData");
            }
        }
    }
}