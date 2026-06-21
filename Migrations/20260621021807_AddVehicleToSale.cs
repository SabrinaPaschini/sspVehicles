using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace sspVehicles.Migrations
{
    /// <inheritdoc />
    public partial class AddVehicleToSale : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "VehicleId",
                table: "Sales",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Sales_VehicleId",
                table: "Sales",
                column: "VehicleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Sales_Vehicles_VehicleId",
                table: "Sales",
                column: "VehicleId",
                principalTable: "Vehicles",
                principalColumn: "VehicleId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sales_Vehicles_VehicleId",
                table: "Sales");

            migrationBuilder.DropIndex(
                name: "IX_Sales_VehicleId",
                table: "Sales");

            migrationBuilder.DropColumn(
                name: "VehicleId",
                table: "Sales");
        }
    }
}
