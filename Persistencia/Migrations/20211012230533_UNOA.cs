using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistencia.Migrations
{
    public partial class UNOA : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CostoProduccion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Inversion = table.Column<int>(type: "int", nullable: false),
                    Gasto = table.Column<int>(type: "int", nullable: false),
                    Ganancia = table.Column<int>(type: "int", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    codigoCosecha = table.Column<int>(type: "int", nullable: true),
                    codigoCarga = table.Column<int>(type: "int", nullable: true),
                    codigoTecnico = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CostoProduccion", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DatosFinca",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombreFinca = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ubicacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    lotesDesignados = table.Column<int>(type: "int", nullable: false),
                    cantidadProductoSembrado = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DatosFinca", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Insumos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombreProducto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cantidadEntrada = table.Column<int>(type: "int", nullable: false),
                    cantidadSalida = table.Column<int>(type: "int", nullable: false),
                    cantidadBodega = table.Column<int>(type: "int", nullable: false),
                    precioCompra = table.Column<int>(type: "int", nullable: false),
                    fechaCompra = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tipo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    numeroAgroquimico = table.Column<int>(type: "int", nullable: true),
                    ingredienteActivo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    numeroRegistro = table.Column<int>(type: "int", nullable: true),
                    responsable = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    numeroMaterial = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Insumos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ListaLogin",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    User = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pass = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ListaLogin", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LoteFinca",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    numeroLote = table.Column<int>(type: "int", nullable: false),
                    cantidadPlantas = table.Column<int>(type: "int", nullable: false),
                    tipoCultivo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    estadoCultivo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoteFinca", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ManoDeObra",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cargo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    salario = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ManoDeObra", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "registros",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Identificacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Apellidos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Usuario = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Contraseña = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_registros", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Trazabilidad",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    lugarProduccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fechaProduccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    encargado = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trazabilidad", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CostoProduccion");

            migrationBuilder.DropTable(
                name: "DatosFinca");

            migrationBuilder.DropTable(
                name: "Insumos");

            migrationBuilder.DropTable(
                name: "ListaLogin");

            migrationBuilder.DropTable(
                name: "LoteFinca");

            migrationBuilder.DropTable(
                name: "ManoDeObra");

            migrationBuilder.DropTable(
                name: "registros");

            migrationBuilder.DropTable(
                name: "Trazabilidad");
        }
    }
}
