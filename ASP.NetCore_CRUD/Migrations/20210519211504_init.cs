using Microsoft.EntityFrameworkCore.Migrations;

namespace ASP.NetCore_CRUD.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    varchar50 = table.Column<string>(name: "varchar(50)", nullable: true),
                    nvarchar250 = table.Column<string>(name: "nvarchar(250)", nullable: false),
                    varchar100 = table.Column<string>(name: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
