//=================================
// Copyright (c) Tarteeb LLC
// Check your english speaking easy
//=================================

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace speech_master.core.Migrations
{
    /// <inheritdoc />
    public partial class CreateAllTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Speeches",
                columns: table => new
                {
                    SpeechId = table.Column<Guid>(type: "TEXT", nullable: false),
                    Sentence = table.Column<string>(type: "TEXT", nullable: false),
                    UserId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Speeches", x => x.SpeechId);
                    table.ForeignKey(
                        name: "FK_Speeches_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Feedbacks",
                columns: table => new
                {
                    FeedbackId = table.Column<Guid>(type: "TEXT", nullable: false),
                    Accuracy = table.Column<decimal>(type: "TEXT", nullable: false),
                    Fluency = table.Column<decimal>(type: "TEXT", nullable: false),
                    Prosody = table.Column<decimal>(type: "TEXT", nullable: false),
                    Completeness = table.Column<decimal>(type: "TEXT", nullable: false),
                    Pronunciation = table.Column<decimal>(type: "TEXT", nullable: false),
                    SpeechId = table.Column<Guid>(type: "TEXT", nullable: false),
                    ParentId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feedbacks", x => x.FeedbackId);
                    table.ForeignKey(
                        name: "FK_Feedbacks_Speeches_SpeechId",
                        column: x => x.SpeechId,
                        principalTable: "Speeches",
                        principalColumn: "SpeechId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Feedbacks_SpeechId",
                table: "Feedbacks",
                column: "SpeechId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Speeches_UserId",
                table: "Speeches",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Feedbacks");

            migrationBuilder.DropTable(
                name: "Speeches");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
