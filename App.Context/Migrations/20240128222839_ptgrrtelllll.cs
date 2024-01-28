using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace App.Context.Migrations
{
    /// <inheritdoc />
    public partial class ptgrrtelllll : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserID",
                table: "Categorys",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Categorys_UserID",
                table: "Categorys",
                column: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Categorys_Users_UserID",
                table: "Categorys",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "UserID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categorys_Users_UserID",
                table: "Categorys");

            migrationBuilder.DropIndex(
                name: "IX_Categorys_UserID",
                table: "Categorys");

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "Categorys");
        }
    }
}
