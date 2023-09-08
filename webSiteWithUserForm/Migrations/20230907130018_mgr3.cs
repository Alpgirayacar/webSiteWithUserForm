using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace webSiteWithUserForm.Migrations
{
    /// <inheritdoc />
    public partial class mgr3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Surnme",
                table: "Visiters",
                newName: "Surname");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Surname",
                table: "Visiters",
                newName: "Surnme");
        }
    }
}
