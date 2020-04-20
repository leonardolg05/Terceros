using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WSTerceros.Migrations
{
    public partial class terceros : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tblEmpresa",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TipoCliente = table.Column<string>(nullable: true),
                    TelefonoCelular = table.Column<string>(nullable: true),
                    Telefono1 = table.Column<string>(nullable: true),
                    Telefono2 = table.Column<string>(nullable: true),
                    Telefono3 = table.Column<string>(nullable: true),
                    Direccion = table.Column<string>(nullable: true),
                    IdMubicipio = table.Column<int>(nullable: false),
                    Nombre = table.Column<string>(nullable: true),
                    NombreRepresentanteLegal = table.Column<string>(nullable: true),
                    IdentificacionRepresentanteLegal = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblEmpresa", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tblPersona",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TipoCliente = table.Column<string>(nullable: true),
                    TelefonoCelular = table.Column<string>(nullable: true),
                    Telefono1 = table.Column<string>(nullable: true),
                    Telefono2 = table.Column<string>(nullable: true),
                    Telefono3 = table.Column<string>(nullable: true),
                    Direccion = table.Column<string>(nullable: true),
                    IdMubicipio = table.Column<int>(nullable: false),
                    Identificacion = table.Column<int>(nullable: false),
                    PrimerApellido = table.Column<string>(nullable: true),
                    SegundoApellido = table.Column<string>(maxLength: 30, nullable: true),
                    PrimerNombre = table.Column<string>(maxLength: 30, nullable: true),
                    SegundoNombre = table.Column<string>(maxLength: 30, nullable: true),
                    Sexo = table.Column<string>(nullable: true),
                    EstadoCivil = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblPersona", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
  
            migrationBuilder.DropTable(
                name: "tblEmpresa");

            migrationBuilder.DropTable(
                name: "tblPersona");
        }
    }
}
