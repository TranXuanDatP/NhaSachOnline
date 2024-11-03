using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Nhà_sách_Online.Data.Migrations
{
    /// <inheritdoc />
    public partial class TenSachMaxLength100 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MaTheLoai",
                table: "Sach");

            migrationBuilder.AlterColumn<string>(
                name: "TenSach",
                table: "Sach",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TenSach",
                table: "Sach",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MaTheLoai",
                table: "Sach",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
