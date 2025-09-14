using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MigracionDB.Migrations
{
    /// <inheritdoc />
    public partial class addRelations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "idAuthor",
                table: "Tickets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_idAuthor",
                table: "Tickets",
                column: "idAuthor");

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Users_idAuthor",
                table: "Tickets",
                column: "idAuthor",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Users_idAuthor",
                table: "Tickets");

            migrationBuilder.DropIndex(
                name: "IX_Tickets_idAuthor",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "idAuthor",
                table: "Tickets");
        }
    }
}
