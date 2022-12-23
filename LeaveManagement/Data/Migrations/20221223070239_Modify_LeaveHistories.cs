using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Data.Migrations
{
    public partial class Modify_LeaveHistories : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ApprovedById",
                table: "LeaveHistories",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_LeaveHistories_ApprovedById",
                table: "LeaveHistories",
                column: "ApprovedById");

            migrationBuilder.AddForeignKey(
                name: "FK_LeaveHistories_AspNetUsers_ApprovedById",
                table: "LeaveHistories",
                column: "ApprovedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LeaveHistories_AspNetUsers_ApprovedById",
                table: "LeaveHistories");

            migrationBuilder.DropIndex(
                name: "IX_LeaveHistories_ApprovedById",
                table: "LeaveHistories");

            migrationBuilder.DropColumn(
                name: "ApprovedById",
                table: "LeaveHistories");
        }
    }
}
