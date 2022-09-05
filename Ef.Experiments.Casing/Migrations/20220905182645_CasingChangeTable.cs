using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ef.Experiments.Casing.Migrations
{
    public partial class CasingChangeTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_People",
                table: "People");

            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.RenameTable(
                name: "People",
                newName: "people",
                newSchema: "dbo");

            migrationBuilder.AddPrimaryKey(
                name: "PK_people",
                schema: "dbo",
                table: "people",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_people",
                schema: "dbo",
                table: "people");

            migrationBuilder.RenameTable(
                name: "people",
                schema: "dbo",
                newName: "People");

            migrationBuilder.AddPrimaryKey(
                name: "PK_People",
                table: "People",
                column: "Id");
        }
    }
}
