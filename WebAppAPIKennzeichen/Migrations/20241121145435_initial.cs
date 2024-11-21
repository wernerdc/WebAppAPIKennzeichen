using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAppAPIKennzeichen.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "KennzeichenInfo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Kennzeichen = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ort = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kreis = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Bundesland = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WappenLink = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KennzeichenInfo", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KennzeichenInfo");
        }
    }
}
