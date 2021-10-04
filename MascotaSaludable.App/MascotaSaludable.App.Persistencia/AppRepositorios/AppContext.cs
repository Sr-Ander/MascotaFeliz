using Microsoft.EntityFrameworkCore;
using MascotaSaludable.App.Dominio;

namespace MascotaSaludable.App.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<Persona> Personas {get; set;}
        public DbSet<Mascota> Mascotas {get; set;}
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder
            .UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog =MascotaSaludableData");
        }
    }
}}