using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WSTerceros.Migrations
{
    public partial class tercerosupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CategoriaLicencia",
                table: "tblPersona",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Codigo_ACEC",
                table: "tblPersona",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Codigo_BARR",
                table: "tblPersona",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Codigo_CIUD",
                table: "tblPersona",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Codigo_ESCI",
                table: "tblPersona",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Codigo_GENE",
                table: "tblPersona",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Codigo_TIDO",
                table: "tblPersona",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Codigo_TIVI",
                table: "tblPersona",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "DireccionCorrespondencia",
                table: "tblPersona",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "tblPersona",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ExentoParafiscales",
                table: "tblPersona",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaExpedicionDocumento",
                table: "tblPersona",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaIngreso",
                table: "tblPersona",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaNacimiento",
                table: "tblPersona",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaUltimaActualizacion",
                table: "tblPersona",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaVencimientoCertificadoJudicial",
                table: "tblPersona",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaVencimientoLicencia",
                table: "tblPersona",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "MesExpedicion",
                table: "tblPersona",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "NumeroCertificadoJudicial",
                table: "tblPersona",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NumeroHijos",
                table: "tblPersona",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "NumeroLicencia",
                table: "tblPersona",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RH",
                table: "tblPersona",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Runt",
                table: "tblPersona",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "TipoSangre",
                table: "tblPersona",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DireccionCorrespondencia",
                table: "tblEmpresa",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "tblEmpresa",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaIngreso",
                table: "tblEmpresa",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Identificacion",
                table: "tblEmpresa",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CategoriaLicencia",
                table: "tblPersona");

            migrationBuilder.DropColumn(
                name: "Codigo_ACEC",
                table: "tblPersona");

            migrationBuilder.DropColumn(
                name: "Codigo_BARR",
                table: "tblPersona");

            migrationBuilder.DropColumn(
                name: "Codigo_CIUD",
                table: "tblPersona");

            migrationBuilder.DropColumn(
                name: "Codigo_ESCI",
                table: "tblPersona");

            migrationBuilder.DropColumn(
                name: "Codigo_GENE",
                table: "tblPersona");

            migrationBuilder.DropColumn(
                name: "Codigo_TIDO",
                table: "tblPersona");

            migrationBuilder.DropColumn(
                name: "Codigo_TIVI",
                table: "tblPersona");

            migrationBuilder.DropColumn(
                name: "DireccionCorrespondencia",
                table: "tblPersona");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "tblPersona");

            migrationBuilder.DropColumn(
                name: "ExentoParafiscales",
                table: "tblPersona");

            migrationBuilder.DropColumn(
                name: "FechaExpedicionDocumento",
                table: "tblPersona");

            migrationBuilder.DropColumn(
                name: "FechaIngreso",
                table: "tblPersona");

            migrationBuilder.DropColumn(
                name: "FechaNacimiento",
                table: "tblPersona");

            migrationBuilder.DropColumn(
                name: "FechaUltimaActualizacion",
                table: "tblPersona");

            migrationBuilder.DropColumn(
                name: "FechaVencimientoCertificadoJudicial",
                table: "tblPersona");

            migrationBuilder.DropColumn(
                name: "FechaVencimientoLicencia",
                table: "tblPersona");

            migrationBuilder.DropColumn(
                name: "MesExpedicion",
                table: "tblPersona");

            migrationBuilder.DropColumn(
                name: "NumeroCertificadoJudicial",
                table: "tblPersona");

            migrationBuilder.DropColumn(
                name: "NumeroHijos",
                table: "tblPersona");

            migrationBuilder.DropColumn(
                name: "NumeroLicencia",
                table: "tblPersona");

            migrationBuilder.DropColumn(
                name: "RH",
                table: "tblPersona");

            migrationBuilder.DropColumn(
                name: "Runt",
                table: "tblPersona");

            migrationBuilder.DropColumn(
                name: "TipoSangre",
                table: "tblPersona");

            migrationBuilder.DropColumn(
                name: "DireccionCorrespondencia",
                table: "tblEmpresa");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "tblEmpresa");

            migrationBuilder.DropColumn(
                name: "FechaIngreso",
                table: "tblEmpresa");

            migrationBuilder.DropColumn(
                name: "Identificacion",
                table: "tblEmpresa");
        }
    }
}
