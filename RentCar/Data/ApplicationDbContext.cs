using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RentCar.Entities.Cars;

namespace RentCar.Data;

public class ApplicationDbContext
    (DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
{
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder)

        modelBuilder.Entity<Car>().HasData(
            new Car
            {
                Id = "1",
                Name = "Audi A4",
                ImageUrl = "https://i.pinimg.com/originals/36/e5/49/36e54938b347edfe73e4eeaf87dcc1a9.jpg",
                Description =
                    "El Audi A4 es un automóvil de turismo de lujo del segmento D producido por el fabricante alemán Audi desde el año 1994. Es una berlina de cuatro puertas, cinco plazas con motor delantero longitudinal y tracción delantera o a las cuatro ruedas. Su principal rival es el BMW Serie 3, el Mercedes-Benz Clase C, el Lexus IS y el Alfa Romeo Giulia."
            },
            new Car
            {
                Id = "2",
                Name = "BMW Serie 3",
                ImageUrl = "https://static.automarket.ro/img/auto_resized/db/article/108/883/109265l-1000x640-b-ae750685.jpg",
                Description = "El BMW Serie 3 es un automóvil de turismo del segmento D producido por el fabricante alemán BMW desde el año 1975. La primera generación del Serie 3 fue construida en la planta de BMW en Múnich, Alemania, pero todos los demás modelos posteriores fueron fabricados en distintas plantas de BMW alrededor del mundo."
            },
            new Car
            {
                Id = "3",
                Name = "Mercedes-Benz Clase C",
                ImageUrl = "https://www.promotor.ro/wp-content/uploads/media/2/41/1815/10679715/1/new-mercedes-cla-45-amg-102.jpg",
                Description = "El Mercedes-Benz Clase C es un automóvil de turismo del segmento D producido por el fabricante alemán Mercedes-Benz. Es el sucesor del Mercedes-Benz 190 y fue reemplazado en 2007 por el Mercedes-Benz Clase C (W204)."
            });
        
        
        
    }
    
    
    public DbSet<Car> Cars { get; set; }
}
    