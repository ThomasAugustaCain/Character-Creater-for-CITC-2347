using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CharacterCreater.Migrations
{
    /// <inheritdoc />
    public partial class Inital : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ancestrys",
                columns: table => new
                {
                    AncestryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AncestryName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ancestrys", x => x.AncestryId);
                });

            migrationBuilder.CreateTable(
                name: "Classes",
                columns: table => new
                {
                    ClassId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InitalLevel = table.Column<int>(type: "int", nullable: false),
                    InitalStrength = table.Column<int>(type: "int", nullable: false),
                    InitalAgility = table.Column<int>(type: "int", nullable: false),
                    InitalEndurance = table.Column<int>(type: "int", nullable: false),
                    InitalVitality = table.Column<int>(type: "int", nullable: false),
                    InitalRadiance = table.Column<int>(type: "int", nullable: false),
                    InitalInferno = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classes", x => x.ClassId);
                });

            migrationBuilder.CreateTable(
                name: "Characters",
                columns: table => new
                {
                    CharacterId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClassId = table.Column<int>(type: "int", nullable: false),
                    AncestryId = table.Column<int>(type: "int", nullable: false),
                    Level = table.Column<int>(type: "int", nullable: false),
                    Strength = table.Column<int>(type: "int", nullable: false),
                    Agility = table.Column<int>(type: "int", nullable: false),
                    Endurance = table.Column<int>(type: "int", nullable: false),
                    Vitality = table.Column<int>(type: "int", nullable: false),
                    Radiance = table.Column<int>(type: "int", nullable: false),
                    Inferno = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Characters", x => x.CharacterId);
                    table.ForeignKey(
                        name: "FK_Characters_Ancestrys_AncestryId",
                        column: x => x.AncestryId,
                        principalTable: "Ancestrys",
                        principalColumn: "AncestryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Characters_Classes_ClassId",
                        column: x => x.ClassId,
                        principalTable: "Classes",
                        principalColumn: "ClassId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Ancestrys",
                columns: new[] { "AncestryId", "AncestryName" },
                values: new object[,]
                {
                    { 1, "Elf" },
                    { 2, "Dwarf" },
                    { 3, "Halfling" },
                    { 4, "Gnome" },
                    { 5, "Human" },
                    { 6, "Half-elf" }
                });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "ClassId", "InitalAgility", "InitalEndurance", "InitalInferno", "InitalLevel", "InitalRadiance", "InitalStrength", "InitalVitality", "Name" },
                values: new object[,]
                {
                    { 1, 8, 15, 8, 10, 9, 12, 11, "Hallowed Knight" },
                    { 2, 10, 13, 8, 12, 8, 16, 10, "Udirangr Warwolf" },
                    { 3, 12, 12, 8, 12, 8, 13, 12, "Partisan" },
                    { 4, 14, 12, 8, 12, 8, 12, 11, "Mournstead Infantry" },
                    { 5, 13, 11, 8, 8, 8, 11, 10, "Blackfeather Ranger" },
                    { 6, 16, 11, 8, 10, 8, 9, 11, "Exiled Stalker" },
                    { 7, 8, 9, 8, 11, 18, 10, 11, "Orian Preacher" },
                    { 8, 8, 11, 18, 10, 8, 9, 9, "Pyric Cultist" },
                    { 9, 9, 9, 9, 1, 9, 9, 9, "Condemned" }
                });

            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "CharacterId", "Agility", "AncestryId", "ClassId", "Endurance", "FirstName", "Inferno", "LastName", "Level", "Radiance", "Strength", "Vitality" },
                values: new object[,]
                {
                    { 1, 8, 5, 1, 16, "Radiant", 8, "Paladin", 51, 34, 13, 26 },
                    { 2, 13, 2, 8, 12, "Seismic", 35, "Sorcerer", 42, 8, 8, 20 },
                    { 3, 13, 6, 9, 13, "Death", 22, "Knight", 54, 22, 13, 25 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Characters_AncestryId",
                table: "Characters",
                column: "AncestryId");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_ClassId",
                table: "Characters",
                column: "ClassId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Characters");

            migrationBuilder.DropTable(
                name: "Ancestrys");

            migrationBuilder.DropTable(
                name: "Classes");
        }
    }
}
