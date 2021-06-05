using Microsoft.EntityFrameworkCore.Migrations;

namespace shoooooop.Migrations
{
    public partial class Initial1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "engineVolume",
                table: "Car",
                nullable: false,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "engineVolume",
                table: "Car",
                nullable: false,
                oldClrType: typeof(float));
        }
    }
}
