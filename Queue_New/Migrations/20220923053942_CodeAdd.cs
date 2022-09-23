using Microsoft.EntityFrameworkCore.Migrations;

namespace Queue_New.Migrations
{
    public partial class CodeAdd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Code",
                table: "gasColumns",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Code",
                table: "gasColumns");
        }
    }
}
