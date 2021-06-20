using Microsoft.EntityFrameworkCore.Migrations;

namespace WhatsApp_Clone.Data.Migrations
{
    public partial class ModifiyTablesV3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropIndex(
                name: "IX_Rooms_User2Id1",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "User1Id1",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "User2Id1",
                table: "Rooms");

            migrationBuilder.AlterColumn<string>(
                name: "User2Id",
                table: "Rooms",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "User1Id",
                table: "Rooms",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_User1Id",
                table: "Rooms",
                column: "User1Id");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_User2Id",
                table: "Rooms",
                column: "User2Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Rooms_AspNetUsers_User1Id",
                table: "Rooms",
                column: "User1Id",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Rooms_AspNetUsers_User2Id",
                table: "Rooms",
                column: "User2Id",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rooms_AspNetUsers_User1Id",
                table: "Rooms");

            migrationBuilder.DropForeignKey(
                name: "FK_Rooms_AspNetUsers_User2Id",
                table: "Rooms");

            migrationBuilder.DropIndex(
                name: "IX_Rooms_User1Id",
                table: "Rooms");

            migrationBuilder.DropIndex(
                name: "IX_Rooms_User2Id",
                table: "Rooms");

            migrationBuilder.AlterColumn<int>(
                name: "User2Id",
                table: "Rooms",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "User1Id",
                table: "Rooms",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "User1Id1",
                table: "Rooms",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "User2Id1",
                table: "Rooms",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_User1Id1",
                table: "Rooms",
                column: "User1Id1");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_User2Id1",
                table: "Rooms",
                column: "User2Id1");

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
    }
}
