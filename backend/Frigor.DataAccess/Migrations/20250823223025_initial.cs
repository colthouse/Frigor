using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Frigor.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Trigger",
                columns: table => new
                {
                    Uuid = table.Column<Guid>(type: "uuid", nullable: false),
                    Type = table.Column<int>(type: "integer", nullable: false),
                    StartDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    EndDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Weekdays = table.Column<int[]>(type: "integer[]", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trigger", x => x.Uuid);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Uuid = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Uuid);
                });

            migrationBuilder.CreateTable(
                name: "Habits",
                columns: table => new
                {
                    Uuid = table.Column<Guid>(type: "uuid", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    TriggerUuid = table.Column<Guid>(type: "uuid", nullable: false),
                    OwnerUuid = table.Column<Guid>(type: "uuid", nullable: false),
                    GodparentUuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Habits", x => x.Uuid);
                    table.ForeignKey(
                        name: "FK_Habits_Trigger_TriggerUuid",
                        column: x => x.TriggerUuid,
                        principalTable: "Trigger",
                        principalColumn: "Uuid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Habits_User_GodparentUuid",
                        column: x => x.GodparentUuid,
                        principalTable: "User",
                        principalColumn: "Uuid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Habits_User_OwnerUuid",
                        column: x => x.OwnerUuid,
                        principalTable: "User",
                        principalColumn: "Uuid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HabitHabitTrigger",
                columns: table => new
                {
                    HabitTriggersUuid = table.Column<Guid>(type: "uuid", nullable: false),
                    HabitsUuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HabitHabitTrigger", x => new { x.HabitTriggersUuid, x.HabitsUuid });
                    table.ForeignKey(
                        name: "FK_HabitHabitTrigger_Habits_HabitsUuid",
                        column: x => x.HabitsUuid,
                        principalTable: "Habits",
                        principalColumn: "Uuid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HabitHabitTrigger_Trigger_HabitTriggersUuid",
                        column: x => x.HabitTriggersUuid,
                        principalTable: "Trigger",
                        principalColumn: "Uuid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Occurrence",
                columns: table => new
                {
                    Uuid = table.Column<Guid>(type: "uuid", nullable: false),
                    IsAchieved = table.Column<bool>(type: "boolean", nullable: false),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    HabitUuid = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Occurrence", x => x.Uuid);
                    table.ForeignKey(
                        name: "FK_Occurrence_Habits_HabitUuid",
                        column: x => x.HabitUuid,
                        principalTable: "Habits",
                        principalColumn: "Uuid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HabitHabitTrigger_HabitsUuid",
                table: "HabitHabitTrigger",
                column: "HabitsUuid");

            migrationBuilder.CreateIndex(
                name: "IX_Habits_GodparentUuid",
                table: "Habits",
                column: "GodparentUuid");

            migrationBuilder.CreateIndex(
                name: "IX_Habits_OwnerUuid",
                table: "Habits",
                column: "OwnerUuid");

            migrationBuilder.CreateIndex(
                name: "IX_Habits_TriggerUuid",
                table: "Habits",
                column: "TriggerUuid");

            migrationBuilder.CreateIndex(
                name: "IX_Occurrence_HabitUuid",
                table: "Occurrence",
                column: "HabitUuid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HabitHabitTrigger");

            migrationBuilder.DropTable(
                name: "Occurrence");

            migrationBuilder.DropTable(
                name: "Habits");

            migrationBuilder.DropTable(
                name: "Trigger");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
