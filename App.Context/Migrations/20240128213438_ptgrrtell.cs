using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace App.Context.Migrations
{
    /// <inheritdoc />
    public partial class ptgrrtell : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           
      
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
