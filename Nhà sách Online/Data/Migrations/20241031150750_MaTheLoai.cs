using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Nhà_sách_Online.Data.Migrations
{
    /// <inheritdoc />
    public partial class MaTheLoai : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MaTheLoai",
                table: "Sach",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MaTheLoai",
                table: "Sach");
        }
    }
}
