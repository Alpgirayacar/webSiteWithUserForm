using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace webSiteWithUserForm.Migrations
{
    /// <inheritdoc />
    public partial class mgr4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Visiters",
                table: "Visiters");

            migrationBuilder.RenameTable(
                name: "Visiters",
                newName: "VisitersList");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VisitersList",
                table: "VisitersList",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_VisitersList",
                table: "VisitersList");

            migrationBuilder.RenameTable(
                name: "VisitersList",
                newName: "Visiters");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Visiters",
                table: "Visiters",
                column: "Id");
        }
    }
}
