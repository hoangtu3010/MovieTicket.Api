using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieTicket.Api.Migrations
{
    public partial class Add_Films : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FilmId",
                table: "Images",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FilmId",
                table: "Categories",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Films",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Trailer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rate = table.Column<float>(type: "real", nullable: false),
                    MovieDuration = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Films", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Images_FilmId",
                table: "Images",
                column: "FilmId");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_FilmId",
                table: "Categories",
                column: "FilmId");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Films_FilmId",
                table: "Categories",
                column: "FilmId",
                principalTable: "Films",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Images_Films_FilmId",
                table: "Images",
                column: "FilmId",
                principalTable: "Films",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Films_FilmId",
                table: "Categories");

            migrationBuilder.DropForeignKey(
                name: "FK_Images_Films_FilmId",
                table: "Images");

            migrationBuilder.DropTable(
                name: "Films");

            migrationBuilder.DropIndex(
                name: "IX_Images_FilmId",
                table: "Images");

            migrationBuilder.DropIndex(
                name: "IX_Categories_FilmId",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "FilmId",
                table: "Images");

            migrationBuilder.DropColumn(
                name: "FilmId",
                table: "Categories");
        }
    }
}
