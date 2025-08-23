using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Frigor.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class UserHabit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Habit",
                table: "User");

            migrationBuilder.AddColumn<List<Guid>>(
                name: "Habits",
                table: "User",
                type: "uuid[]",
                nullable: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Habits",
                table: "User");

            migrationBuilder.AddColumn<int>(
                name: "Habit",
                table: "User",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }
    }
}
