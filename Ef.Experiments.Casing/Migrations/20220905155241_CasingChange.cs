using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ef.Experiments.Casing.Migrations
{
    public partial class CasingChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "People",
                newName: "lastName");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "People",
                newName: "firstName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "lastName",
                table: "People",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "firstName",
                table: "People",
                newName: "FirstName");
        }
    }
}
