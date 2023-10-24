using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace webapi.Migrations
{
    /// <inheritdoc />
    public partial class GameUpdate6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "board",
                table: "game_rooms",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FirstPlayerId",
                table: "game_rooms",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SecondPlayerId",
                table: "game_rooms",
                type: "integer",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstPlayerId",
                table: "game_rooms");

            migrationBuilder.DropColumn(
                name: "SecondPlayerId",
                table: "game_rooms");

            migrationBuilder.AlterColumn<string>(
                name: "board",
                table: "game_rooms",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);
        }
    }
}
