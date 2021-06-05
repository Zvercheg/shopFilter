using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace shoooooop.Migrations
{
    public partial class af : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ShopCartItem");

            migrationBuilder.AddColumn<string>(
                name: "Transmission",
                table: "Car",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "bodyType",
                table: "Car",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "damage",
                table: "Car",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "driveUnit",
                table: "Car",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "engineVolume",
                table: "Car",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "mileage",
                table: "Car",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "year",
                table: "Car",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Transmission",
                table: "Car");

            migrationBuilder.DropColumn(
                name: "bodyType",
                table: "Car");

            migrationBuilder.DropColumn(
                name: "damage",
                table: "Car");

            migrationBuilder.DropColumn(
                name: "driveUnit",
                table: "Car");

            migrationBuilder.DropColumn(
                name: "engineVolume",
                table: "Car");

            migrationBuilder.DropColumn(
                name: "mileage",
                table: "Car");

            migrationBuilder.DropColumn(
                name: "year",
                table: "Car");

            migrationBuilder.CreateTable(
                name: "ShopCartItem",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ShopCartId = table.Column<string>(nullable: true),
                    carid = table.Column<int>(nullable: true),
                    price = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShopCartItem", x => x.id);
                    table.ForeignKey(
                        name: "FK_ShopCartItem_Car_carid",
                        column: x => x.carid,
                        principalTable: "Car",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ShopCartItem_carid",
                table: "ShopCartItem",
                column: "carid");
        }
    }
}
