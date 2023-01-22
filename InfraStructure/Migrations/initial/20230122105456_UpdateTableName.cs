using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InfraStructure.Migrations.initial
{
    /// <inheritdoc />
    public partial class UpdateTableName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Weninars",
                table: "Weninars");

            migrationBuilder.RenameTable(
                name: "Weninars",
                newName: "Webinars");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Webinars",
                table: "Webinars",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Webinars",
                table: "Webinars");

            migrationBuilder.RenameTable(
                name: "Webinars",
                newName: "Weninars");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Weninars",
                table: "Weninars",
                column: "Id");
        }
    }
}
