using Microsoft.EntityFrameworkCore.Migrations;

namespace UwuBlogAccesoDatos.Migrations
{
    public partial class CambioDato : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Order",
                table: "Category",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Order",
                table: "Category",
                type: "integer",
                nullable: false,
                oldClrType: typeof(string));
        }
    }
}
