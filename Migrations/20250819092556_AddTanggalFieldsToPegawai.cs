using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PegawaiMVC.Migrations
{
    /// <inheritdoc />
    public partial class AddTanggalFieldsToPegawai : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "TanggalLahir",
                table: "Pegawais",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "TanggalMasukKerja",
                table: "Pegawais",
                type: "datetime(6)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TanggalLahir",
                table: "Pegawais");

            migrationBuilder.DropColumn(
                name: "TanggalMasukKerja",
                table: "Pegawais");
        }
    }
}
