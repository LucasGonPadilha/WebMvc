using Microsoft.EntityFrameworkCore.Migrations;

namespace SalesWebMvc.Migrations
{
    public partial class DepartmentForeignKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Seller_Department_DerpartmentId",
                table: "Seller");

            migrationBuilder.DropIndex(
                name: "IX_Seller_DerpartmentId",
                table: "Seller");

            migrationBuilder.DropColumn(
                name: "DerpartmentId",
                table: "Seller");

            migrationBuilder.AddColumn<int>(
                name: "DepartmentId",
                table: "Seller",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Seller_DepartmentId",
                table: "Seller",
                column: "DepartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Seller_Department_DepartmentId",
                table: "Seller",
                column: "DepartmentId",
                principalTable: "Department",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Seller_Department_DepartmentId",
                table: "Seller");

            migrationBuilder.DropIndex(
                name: "IX_Seller_DepartmentId",
                table: "Seller");

            migrationBuilder.DropColumn(
                name: "DepartmentId",
                table: "Seller");

            migrationBuilder.AddColumn<int>(
                name: "DerpartmentId",
                table: "Seller",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Seller_DerpartmentId",
                table: "Seller",
                column: "DerpartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Seller_Department_DerpartmentId",
                table: "Seller",
                column: "DerpartmentId",
                principalTable: "Department",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
