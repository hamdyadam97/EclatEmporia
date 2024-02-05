using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace App.Context.Migrations
{
    /// <inheritdoc />
    public partial class PPPPPPPPPPPPP : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "EnsureAdmin",
                table: "Users",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EnsureAdmin",
                table: "Users");
        }
    }
}
