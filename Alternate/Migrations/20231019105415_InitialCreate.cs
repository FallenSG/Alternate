using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Alternate.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Taxes",
                columns: table => new
                {
                    TaxId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TaxRate = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Taxes", x => x.TaxId);
                });

            migrationBuilder.CreateTable(
                name: "Units",
                columns: table => new
                {
                    UnitId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Units", x => x.UnitId);
                });

            migrationBuilder.CreateTable(
                name: "Parent_Products",
                columns: table => new
                {
                    Parent_ProductId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Alias = table.Column<string>(type: "TEXT", nullable: true),
                    PrintName = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    UnitId = table.Column<int>(type: "INTEGER", nullable: false),
                    Tax = table.Column<int>(type: "INTEGER", nullable: false),
                    SP = table.Column<int>(type: "INTEGER", nullable: false),
                    CP = table.Column<int>(type: "INTEGER", nullable: false),
                    MRP = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parent_Products", x => x.Parent_ProductId);
                    table.ForeignKey(
                        name: "FK_Parent_Products_Units_UnitId",
                        column: x => x.UnitId,
                        principalTable: "Units",
                        principalColumn: "UnitId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Unit_Conversions",
                columns: table => new
                {
                    Unit_ConversionId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MainUnitUnitId = table.Column<int>(type: "INTEGER", nullable: false),
                    SubUnitUnitId = table.Column<int>(type: "INTEGER", nullable: false),
                    ConFact = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Unit_Conversions", x => x.Unit_ConversionId);
                    table.ForeignKey(
                        name: "FK_Unit_Conversions_Units_MainUnitUnitId",
                        column: x => x.MainUnitUnitId,
                        principalTable: "Units",
                        principalColumn: "UnitId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Unit_Conversions_Units_SubUnitUnitId",
                        column: x => x.SubUnitUnitId,
                        principalTable: "Units",
                        principalColumn: "UnitId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Parent_Products_UnitId",
                table: "Parent_Products",
                column: "UnitId");

            migrationBuilder.CreateIndex(
                name: "IX_Unit_Conversions_MainUnitUnitId",
                table: "Unit_Conversions",
                column: "MainUnitUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_Unit_Conversions_SubUnitUnitId",
                table: "Unit_Conversions",
                column: "SubUnitUnitId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Parent_Products");

            migrationBuilder.DropTable(
                name: "Taxes");

            migrationBuilder.DropTable(
                name: "Unit_Conversions");

            migrationBuilder.DropTable(
                name: "Units");
        }
    }
}
