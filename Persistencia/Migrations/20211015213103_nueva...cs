using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistencia.Migrations
{
    public partial class nueva : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "CostoProduccion");

            migrationBuilder.DropColumn(
                name: "codigoCarga",
                table: "CostoProduccion");

            migrationBuilder.DropColumn(
                name: "codigoCosecha",
                table: "CostoProduccion");

            migrationBuilder.DropColumn(
                name: "codigoTecnico",
                table: "CostoProduccion");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "ManoDeObra",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "codigoCarga",
                table: "ManoDeObra",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "codigoCosecha",
                table: "ManoDeObra",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "codigoTecnico",
                table: "ManoDeObra",
                type: "int",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "ManoDeObra");

            migrationBuilder.DropColumn(
                name: "codigoCarga",
                table: "ManoDeObra");

            migrationBuilder.DropColumn(
                name: "codigoCosecha",
                table: "ManoDeObra");

            migrationBuilder.DropColumn(
                name: "codigoTecnico",
                table: "ManoDeObra");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "CostoProduccion",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "codigoCarga",
                table: "CostoProduccion",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "codigoCosecha",
                table: "CostoProduccion",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "codigoTecnico",
                table: "CostoProduccion",
                type: "int",
                nullable: true);
        }
    }
}
