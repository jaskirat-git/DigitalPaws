using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DigitalPaws.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pets_Users_OwnerId",
                table: "Pets");

            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "Users");

            migrationBuilder.AlterColumn<string>(
                name: "QRCodeUrl",
                table: "Pets",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "OwnerId",
                table: "Pets",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "MedicalConditions",
                table: "Pets",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "DisplayPictureUrl",
                table: "Pets",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "AdoptionModels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Breed = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsAvailable = table.Column<bool>(type: "bit", nullable: false),
                    Owner = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Contact = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdoptionModels", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AdoptionModels",
                columns: new[] { "Id", "Breed", "Contact", "ImageUrl", "IsAvailable", "Name", "Owner", "Price" },
                values: new object[,]
                {
                    { 1, "Golden Retriever", "5234567890", "/images/dog3.jpg", true, "Jack", "John Doe", "$500" },
                    { 2, "Labrador", "4234567891", "/images/Lab.jpg", true, "Jhonny", "Jane Doe", "$600" },
                    { 3, "Husky", "7234567893", "/images/dog4.jpg", true, "Smarty", "Rony", "$700" },
                    { 4, "German Shepherd", "8234567894", "/images/German.jpg", true, "Jerry", "Andrew", "$800" },
                    { 5, "French Bulldog", "2234567594", "/images/bully.jpeg", true, "Smurf", "Samson", "$900" },
                    { 6, "Rottweiler", "6234563890", "/images/Roty.jpg", true, "fiend", "Chris", "$1000" },
                    { 7, "Pomeranian", "9234567820", "images/Pom.jpg", false, "Spencer", "David", "$700" },
                    { 8, "Doberman Pincher", "2234565666", "/images/Doby.jpg", false, "Nox", "Derek", "$800" },
                    { 9, "Boxer", "3234567446", "/images/boxer.jpg", false, "Bear", "Dylan", "$900" },
                    { 10, "Shiba Inu", "6126457690", "/images/Shiba.jpg", false, "Timmy", "Dexter", "$1000" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Pets_Users_OwnerId",
                table: "Pets",
                column: "OwnerId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pets_Users_OwnerId",
                table: "Pets");

            migrationBuilder.DropTable(
                name: "AdoptionModels");

            migrationBuilder.DropColumn(
                name: "DisplayPictureUrl",
                table: "Pets");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfBirth",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<string>(
                name: "QRCodeUrl",
                table: "Pets",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "OwnerId",
                table: "Pets",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MedicalConditions",
                table: "Pets",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Pets_Users_OwnerId",
                table: "Pets",
                column: "OwnerId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
