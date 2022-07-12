using Microsoft.EntityFrameworkCore.Migrations;

namespace Bconnect.data.Migrations
{
    public partial class ChangeColBusinessCard : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address1",
                table: "BusinessCards");

            migrationBuilder.DropColumn(
                name: "Address2",
                table: "BusinessCards");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "BusinessCards",
                newName: "FullName");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "BusinessCards",
                newName: "Address");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FullName",
                table: "BusinessCards",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "Address",
                table: "BusinessCards",
                newName: "FirstName");

            migrationBuilder.AddColumn<string>(
                name: "Address1",
                table: "BusinessCards",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Address2",
                table: "BusinessCards",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
