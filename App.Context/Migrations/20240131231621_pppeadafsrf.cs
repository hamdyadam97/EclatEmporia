using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace App.Context.Migrations
{
    /// <inheritdoc />
    public partial class pppeadafsrf : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsAddOrder",
                table: "CartProducts",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsAddOrder",
                table: "CartProducts");
        }
    }
}
