using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DigitalPaws.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    MobileNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MedicalConditions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QRCodeUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DisplayPictureUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OwnerId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pets_Users_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "Users",
                        principalColumn: "Id");
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
                    { 10, "Shiba Inu", "6126457690", "/images/Shiba.jpg", false, "Timmy", "Dexter", "$1000" },
                    { 11, "British Short Haired", "8916457690", "/images/britis.jpeg", true, "Tom", "Kelly", "$500" },
                    { 12, "Bombay", "4381237690", "/images/Bombay.jpg", false, "Charmy", "Alize", "$650" },
                    { 13, "American Curl", "7651237694", "/images/AmericanCurl.jpg", true, "Chase", "Jeremy", "$550" },
                    { 14, "Somali", "4321247634", "/images/somali.jpg", true, "Candy", "Casey", "$450" },
                    { 15, "Albino Budgerigar", "8321247635", "/images/bud.jpg", true, "Cane", "Kate", "$450" },
                    { 16, "Ring Neck Parakeet", "9321287635", "/images/ring.jpg", true, "Honey", "Shelly", "$450" },
                    { 17, "Scarlet Macaw", "5321287635", "/images/macaw.jpg", false, "Andrei", "Seth", "$450" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pets_OwnerId",
                table: "Pets",
                column: "OwnerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdoptionModels");

            migrationBuilder.DropTable(
                name: "Pets");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
