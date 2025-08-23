using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Frigor.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class OccId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Habits",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Habits",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<Guid>(
                name: "TriggerUuid",
                table: "Habits",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "Occurrence",
                columns: table => new
                {
                    Uuid = table.Column<Guid>(type: "uuid", nullable: false),
                    IsAchieved = table.Column<bool>(type: "boolean", nullable: false),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Occurrence", x => x.Uuid);
                });

            migrationBuilder.CreateTable(
                name: "Trigger",
                columns: table => new
                {
                    Uuid = table.Column<Guid>(type: "uuid", nullable: false),
                    Type = table.Column<int>(type: "integer", nullable: false),
                    OccurrenceUuid = table.Column<Guid>(type: "uuid", nullable: false),
                    Habits = table.Column<List<Guid>>(type: "uuid[]", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trigger", x => x.Uuid);
                    table.ForeignKey(
                        name: "FK_Trigger_Occurrence_OccurrenceUuid",
                        column: x => x.OccurrenceUuid,
                        principalTable: "Occurrence",
                        principalColumn: "Uuid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Habits_TriggerUuid",
                table: "Habits",
                column: "TriggerUuid");

            migrationBuilder.CreateIndex(
                name: "IX_Trigger_OccurrenceUuid",
                table: "Trigger",
                column: "OccurrenceUuid");

            migrationBuilder.AddForeignKey(
                name: "FK_Habits_Trigger_TriggerUuid",
                table: "Habits",
                column: "TriggerUuid",
                principalTable: "Trigger",
                principalColumn: "Uuid",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Habits_Trigger_TriggerUuid",
                table: "Habits");

            migrationBuilder.DropTable(
                name: "Trigger");

            migrationBuilder.DropTable(
                name: "Occurrence");

            migrationBuilder.DropIndex(
                name: "IX_Habits_TriggerUuid",
                table: "Habits");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Habits");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Habits");

            migrationBuilder.DropColumn(
                name: "TriggerUuid",
                table: "Habits");
        }
    }
}
