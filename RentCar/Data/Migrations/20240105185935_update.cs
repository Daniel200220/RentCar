using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RentCar.Migrations
{
    /// <inheritdoc />
    public partial class update : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    ImageUrl = table.Column<string>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "Description", "ImageUrl", "Name" },
                values: new object[,]
                {
                    { "1", "El Audi A4 es un automóvil de turismo de lujo del segmento D producido por el fabricante alemán Audi desde el año 1994. Es una berlina de cuatro puertas, cinco plazas con motor delantero longitudinal y tracción delantera o a las cuatro ruedas. Su principal rival es el BMW Serie 3, el Mercedes-Benz Clase C, el Lexus IS y el Alfa Romeo Giulia.", "https://i.pinimg.com/originals/36/e5/49/36e54938b347edfe73e4eeaf87dcc1a9.jpg", "Audi A4" },
                    { "2", "El BMW Serie 3 es un automóvil de turismo del segmento D producido por el fabricante alemán BMW desde el año 1975. La primera generación del Serie 3 fue construida en la planta de BMW en Múnich, Alemania, pero todos los demás modelos posteriores fueron fabricados en distintas plantas de BMW alrededor del mundo.", "https://static.automarket.ro/img/auto_resized/db/article/108/883/109265l-1000x640-b-ae750685.jpg", "BMW Serie 3" },
                    { "3", "El Mercedes-Benz Clase C es un automóvil de turismo del segmento D producido por el fabricante alemán Mercedes-Benz. Es el sucesor del Mercedes-Benz 190 y fue reemplazado en 2007 por el Mercedes-Benz Clase C (W204).", "https://www.promotor.ro/wp-content/uploads/media/2/41/1815/10679715/1/new-mercedes-cla-45-amg-102.jpg", "Mercedes-Benz Clase C" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cars");
        }
    }
}
