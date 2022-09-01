using Microsoft.EntityFrameworkCore.Migrations;

namespace Queue_New.Migrations
{
    public partial class InitGasColumns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "gasColumns",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ColumnNumber = table.Column<int>(nullable: false),
                    QueueTime = table.Column<string>(nullable: true),
                    Occupied = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_gasColumns", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "gasColumns");
        }
    }
}
