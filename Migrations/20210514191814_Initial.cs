using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAPi_Kairos.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Personas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombrePersona = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    paisOrigen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ubicacionPersona = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    necesidadPersona = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    historialPersona = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personas", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Personas");
        }
    }
}
