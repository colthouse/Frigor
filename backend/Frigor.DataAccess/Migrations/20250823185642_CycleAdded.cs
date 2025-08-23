using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Frigor.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class CycleAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "CycleUuid",
                table: "Trigger",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "Cycle",
                columns: table => new
                {
                    Uuid = table.Column<Guid>(type: "uuid", nullable: false),
                    StartDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    EndDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Weekdays = table.Column<int[]>(type: "integer[]", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cycle", x => x.Uuid);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Trigger_CycleUuid",
                table: "Trigger",
                column: "CycleUuid");

            migrationBuilder.AddForeignKey(
                name: "FK_Trigger_Cycle_CycleUuid",
                table: "Trigger",
                column: "CycleUuid",
                principalTable: "Cycle",
                principalColumn: "Uuid",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Trigger_Cycle_CycleUuid",
                table: "Trigger");

            migrationBuilder.DropTable(
                name: "Cycle");

            migrationBuilder.DropIndex(
                name: "IX_Trigger_CycleUuid",
                table: "Trigger");

            migrationBuilder.DropColumn(
                name: "CycleUuid",
                table: "Trigger");
        }
    }
}
