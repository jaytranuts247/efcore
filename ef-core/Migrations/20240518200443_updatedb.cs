using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ef_core.Migrations
{
    /// <inheritdoc />
    public partial class updatedb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Standards_StandardRefId",
                table: "Students");

            migrationBuilder.AlterColumn<int>(
                name: "StandardRefId",
                table: "Students",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Standards_StandardRefId",
                table: "Students",
                column: "StandardRefId",
                principalTable: "Standards",
                principalColumn: "StandardId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Standards_StandardRefId",
                table: "Students");

            migrationBuilder.AlterColumn<int>(
                name: "StandardRefId",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Standards_StandardRefId",
                table: "Students",
                column: "StandardRefId",
                principalTable: "Standards",
                principalColumn: "StandardId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
