using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PCBuilderDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class HazirSistemResimEkle : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "PrebuiltSystems",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "PrebuiltSystems");
        }
    }
}
