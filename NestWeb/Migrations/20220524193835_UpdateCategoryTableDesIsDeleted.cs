using Microsoft.EntityFrameworkCore.Migrations;

namespace NestWeb.Migrations
{
    public partial class UpdateCategoryTableDesIsDeleted : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "İsDeleted",
                table: "Categories",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "İsDeleted",
                table: "Categories");
        }
    }
}
