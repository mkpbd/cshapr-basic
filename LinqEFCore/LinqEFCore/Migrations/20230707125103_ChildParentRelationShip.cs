using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LinqEFCore.Migrations
{
    /// <inheritdoc />
    public partial class ChildParentRelationShip : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Purchases_Customers_CustomerID",
                table: "Purchases");

            migrationBuilder.AlterColumn<int>(
                name: "CustomerID",
                table: "Purchases",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Purchases_Customers_CustomerID",
                table: "Purchases",
                column: "CustomerID",
                principalTable: "Customers",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Purchases_Customers_CustomerID",
                table: "Purchases");

            migrationBuilder.AlterColumn<int>(
                name: "CustomerID",
                table: "Purchases",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Purchases_Customers_CustomerID",
                table: "Purchases",
                column: "CustomerID",
                principalTable: "Customers",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
