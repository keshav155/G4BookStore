using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookStoreApp.Data.Migrations
{
    public partial class BookUID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BookUID",
                table: "Book",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BookUID",
                table: "Book");
        }
    }
}
