using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PegawaiMVC.Migrations
{
    /// <inheritdoc />
    public partial class AddGajiToPegawai : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Gaji",
                table: "Pegawais",
                type: "decimal(65,30)",
                nullable: false,
                defaultValue: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Gaji",
                table: "Pegawais");
        }
    }
}
