using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LawyerSuits.DAL.Migrations
{
    public partial class Lawyer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Lawyers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    LawyerName = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false),
                    LawyerCPF = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false),
                    LawyerOABOrder = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false),
                    OccupationArea = table.Column<int>(type: "INTEGER", nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "TEXT", nullable: false),
                    LastModified = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CreatedById = table.Column<string>(type: "TEXT", maxLength: 255, nullable: true),
                    ModifiedById = table.Column<string>(type: "TEXT", maxLength: 255, nullable: true),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lawyers", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Lawyers");
        }
    }
}
