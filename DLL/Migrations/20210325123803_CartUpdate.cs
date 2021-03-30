using Microsoft.EntityFrameworkCore.Migrations;

namespace DLL.Migrations
{
    public partial class CartUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Category",
                table: "ProductContextEntities");

            migrationBuilder.DropColumn(
                name: "Category",
                table: "CartOrderItemContextEntities");

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "ProductContextEntities",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CartId",
                table: "CartOrderItemContextEntities",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "CartOrderItemContextEntities",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ProductCategoryContextEntities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategoryContextEntities", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductContextEntities_CategoryId",
                table: "ProductContextEntities",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_CartOrderItemContextEntities_CategoryId",
                table: "CartOrderItemContextEntities",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_CartOrderItemContextEntities_ProductCategoryContextEntities_CategoryId",
                table: "CartOrderItemContextEntities",
                column: "CategoryId",
                principalTable: "ProductCategoryContextEntities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductContextEntities_ProductCategoryContextEntities_CategoryId",
                table: "ProductContextEntities",
                column: "CategoryId",
                principalTable: "ProductCategoryContextEntities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartOrderItemContextEntities_ProductCategoryContextEntities_CategoryId",
                table: "CartOrderItemContextEntities");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductContextEntities_ProductCategoryContextEntities_CategoryId",
                table: "ProductContextEntities");

            migrationBuilder.DropTable(
                name: "ProductCategoryContextEntities");

            migrationBuilder.DropIndex(
                name: "IX_ProductContextEntities_CategoryId",
                table: "ProductContextEntities");

            migrationBuilder.DropIndex(
                name: "IX_CartOrderItemContextEntities_CategoryId",
                table: "CartOrderItemContextEntities");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "ProductContextEntities");

            migrationBuilder.DropColumn(
                name: "CartId",
                table: "CartOrderItemContextEntities");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "CartOrderItemContextEntities");

            migrationBuilder.AddColumn<int>(
                name: "Category",
                table: "ProductContextEntities",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Category",
                table: "CartOrderItemContextEntities",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
