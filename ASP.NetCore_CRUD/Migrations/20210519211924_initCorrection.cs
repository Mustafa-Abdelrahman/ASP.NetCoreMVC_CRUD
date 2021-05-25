using Microsoft.EntityFrameworkCore.Migrations;

namespace ASP.NetCore_CRUD.Migrations
{
    public partial class initCorrection : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "varchar(100)",
                table: "Employees",
                newName: "Position");

            migrationBuilder.RenameColumn(
                name: "nvarchar(250)",
                table: "Employees",
                newName: "FullName");

            migrationBuilder.RenameColumn(
                name: "varchar(50)",
                table: "Employees",
                newName: "EmployeeCode");

            migrationBuilder.AlterColumn<string>(
                name: "Position",
                table: "Employees",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FullName",
                table: "Employees",
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "EmployeeCode",
                table: "Employees",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OfficeLocation",
                table: "Employees",
                maxLength: 50,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OfficeLocation",
                table: "Employees");

            migrationBuilder.RenameColumn(
                name: "Position",
                table: "Employees",
                newName: "varchar(100)");

            migrationBuilder.RenameColumn(
                name: "FullName",
                table: "Employees",
                newName: "nvarchar(250)");

            migrationBuilder.RenameColumn(
                name: "EmployeeCode",
                table: "Employees",
                newName: "varchar(50)");

            migrationBuilder.AlterColumn<string>(
                name: "varchar(100)",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "nvarchar(250)",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 250);

            migrationBuilder.AlterColumn<string>(
                name: "varchar(50)",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true);
        }
    }
}
