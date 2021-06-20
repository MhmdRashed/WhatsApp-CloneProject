using Microsoft.EntityFrameworkCore.Migrations;

namespace WhatsApp_Clone.Data.Migrations
{
    public partial class ModifiyTablesV2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rooms_AspNetUsers_ApplicationUserId",
                table: "Rooms");

            migrationBuilder.RenameColumn(
                name: "ApplicationUserId",
                table: "Rooms",
                newName: "User2Id1");

            migrationBuilder.RenameIndex(
                name: "IX_Rooms_ApplicationUserId",
                table: "Rooms",
                newName: "IX_Rooms_User2Id1");

            migrationBuilder.AddColumn<string>(
                name: "User1Id1",
                table: "Rooms",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_User1Id1",
                table: "Rooms",
                column: "User1Id1");

            migrationBuilder.AddForeignKey(
                name: "FK_Rooms_AspNetUsers_User1Id1",
                table: "Rooms",
                column: "User1Id1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Rooms_AspNetUsers_User2Id1",
                table: "Rooms",
                column: "User2Id1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rooms_AspNetUsers_User1Id1",
                table: "Rooms");

            migrationBuilder.DropForeignKey(
                name: "FK_Rooms_AspNetUsers_User2Id1",
                table: "Rooms");

            migrationBuilder.DropIndex(
                name: "IX_Rooms_User1Id1",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "User1Id1",
                table: "Rooms");

            migrationBuilder.RenameColumn(
                name: "User2Id1",
                table: "Rooms",
                newName: "ApplicationUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Rooms_User2Id1",
                table: "Rooms",
                newName: "IX_Rooms_ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Rooms_AspNetUsers_ApplicationUserId",
                table: "Rooms",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
