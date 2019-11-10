using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Webapp.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "JsonEditor",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    UpdateTime = table.Column<DateTime>(nullable: false),
                    Content = table.Column<string>(nullable: true),
                    Note = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JsonEditor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Randomuser",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(nullable: false),
                    gender = table.Column<string>(nullable: true),
                    location = table.Column<string>(nullable: true),
                    registered = table.Column<string>(nullable: true),
                    phone = table.Column<string>(nullable: true),
                    cell = table.Column<string>(nullable: true),
                    large_picture = table.Column<string>(nullable: true),
                    medium_picture = table.Column<string>(nullable: true),
                    thumbnail_picture = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Randomuser", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "JsonEditor");

            migrationBuilder.DropTable(
                name: "Randomuser");
        }
    }
}
