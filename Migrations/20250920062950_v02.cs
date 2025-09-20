using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ITI_DB.Migrations
{
    /// <inheritdoc />
    public partial class v02 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Students_SupervisorStId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_SupervisorStId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "SupervisorStId",
                table: "Students");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SupervisorStId",
                table: "Students",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Students_SupervisorStId",
                table: "Students",
                column: "SupervisorStId");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Students_SupervisorStId",
                table: "Students",
                column: "SupervisorStId",
                principalTable: "Students",
                principalColumn: "StId");
        }
    }
}
