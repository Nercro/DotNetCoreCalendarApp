using Microsoft.EntityFrameworkCore.Migrations;

namespace CalendarApop.Data.Migrations
{
    public partial class userevents : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "CalendarEvents",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CalendarEvents_UserId",
                table: "CalendarEvents",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_CalendarEvents_AspNetUsers_UserId",
                table: "CalendarEvents",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CalendarEvents_AspNetUsers_UserId",
                table: "CalendarEvents");

            migrationBuilder.DropIndex(
                name: "IX_CalendarEvents_UserId",
                table: "CalendarEvents");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "CalendarEvents");
        }
    }
}
