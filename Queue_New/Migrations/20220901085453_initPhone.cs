using Microsoft.EntityFrameworkCore.Migrations;

namespace Queue_New.Migrations
{
    public partial class initPhone : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "QueueTime",
                table: "gasColumns",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ClienPhoneNumber",
                table: "gasColumns",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ClienPhoneNumber",
                table: "gasColumns");

            migrationBuilder.AlterColumn<string>(
                name: "QueueTime",
                table: "gasColumns",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
