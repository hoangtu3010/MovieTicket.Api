using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieTicket.Api.Migrations
{
    public partial class Add_Bookings : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ListFoodId",
                table: "FoodInfo",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ListFood",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ListFood", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Bookings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ListFoodId = table.Column<int>(type: "int", nullable: true),
                    Total = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BookingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FilmId = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    RoomId = table.Column<int>(type: "int", nullable: true),
                    BranchId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bookings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bookings_Branches_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Bookings_Films_FilmId",
                        column: x => x.FilmId,
                        principalTable: "Films",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Bookings_ListFood_ListFoodId",
                        column: x => x.ListFoodId,
                        principalTable: "ListFood",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Bookings_Rooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Rooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Bookings_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ComboInfo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ComboFoodId = table.Column<int>(type: "int", nullable: true),
                    Qty = table.Column<int>(type: "int", nullable: false),
                    ListFoodId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComboInfo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ComboInfo_ComboFoods_ComboFoodId",
                        column: x => x.ComboFoodId,
                        principalTable: "ComboFoods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ComboInfo_ListFood_ListFoodId",
                        column: x => x.ListFoodId,
                        principalTable: "ListFood",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FoodInfo_ListFoodId",
                table: "FoodInfo",
                column: "ListFoodId");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_BranchId",
                table: "Bookings",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_FilmId",
                table: "Bookings",
                column: "FilmId");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_ListFoodId",
                table: "Bookings",
                column: "ListFoodId");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_RoomId",
                table: "Bookings",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_UserId",
                table: "Bookings",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ComboInfo_ComboFoodId",
                table: "ComboInfo",
                column: "ComboFoodId");

            migrationBuilder.CreateIndex(
                name: "IX_ComboInfo_ListFoodId",
                table: "ComboInfo",
                column: "ListFoodId");

            migrationBuilder.AddForeignKey(
                name: "FK_FoodInfo_ListFood_ListFoodId",
                table: "FoodInfo",
                column: "ListFoodId",
                principalTable: "ListFood",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FoodInfo_ListFood_ListFoodId",
                table: "FoodInfo");

            migrationBuilder.DropTable(
                name: "Bookings");

            migrationBuilder.DropTable(
                name: "ComboInfo");

            migrationBuilder.DropTable(
                name: "ListFood");

            migrationBuilder.DropIndex(
                name: "IX_FoodInfo_ListFoodId",
                table: "FoodInfo");

            migrationBuilder.DropColumn(
                name: "ListFoodId",
                table: "FoodInfo");
        }
    }
}
