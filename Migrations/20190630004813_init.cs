using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace kafer_house.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(nullable: false),
                    code = table.Column<string>(nullable: false),
                    price = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ShoppingMall",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingMall", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Branch",
                columns: table => new
                {
                    branchId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    branchName = table.Column<string>(nullable: false),
                    shoppingmallID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Branch", x => x.branchId);
                    table.ForeignKey(
                        name: "FK_Branch_ShoppingMall_shoppingmallID",
                        column: x => x.shoppingmallID,
                        principalTable: "ShoppingMall",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CartActual",
                columns: table => new
                {
                    cartId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    createdDate = table.Column<DateTime>(nullable: false),
                    dateSold = table.Column<DateTime>(nullable: false),
                    totalRevenue = table.Column<double>(nullable: false),
                    branchId = table.Column<int>(nullable: false),
                    shoppingmallID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartActual", x => x.cartId);
                    table.ForeignKey(
                        name: "FK_CartActual_Branch_branchId",
                        column: x => x.branchId,
                        principalTable: "Branch",
                        principalColumn: "branchId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CartActual_ShoppingMall_shoppingmallID",
                        column: x => x.shoppingmallID,
                        principalTable: "ShoppingMall",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Delivery",
                columns: table => new
                {
                    deliveryId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    deliveryDate = table.Column<DateTime>(nullable: false),
                    productLotDate = table.Column<DateTime>(nullable: false),
                    branchId = table.Column<int>(nullable: false),
                    shoppingmallID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Delivery", x => x.deliveryId);
                    table.ForeignKey(
                        name: "FK_Delivery_Branch_branchId",
                        column: x => x.branchId,
                        principalTable: "Branch",
                        principalColumn: "branchId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Delivery_ShoppingMall_shoppingmallID",
                        column: x => x.shoppingmallID,
                        principalTable: "ShoppingMall",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Receive",
                columns: table => new
                {
                    receiveId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    receiveDate = table.Column<DateTime>(nullable: false),
                    productLotDate = table.Column<DateTime>(nullable: false),
                    branchId = table.Column<int>(nullable: false),
                    shoppingmallID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Receive", x => x.receiveId);
                    table.ForeignKey(
                        name: "FK_Receive_Branch_branchId",
                        column: x => x.branchId,
                        principalTable: "Branch",
                        principalColumn: "branchId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Receive_ShoppingMall_shoppingmallID",
                        column: x => x.shoppingmallID,
                        principalTable: "ShoppingMall",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CartItemActual",
                columns: table => new
                {
                    cartItemId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    productId = table.Column<string>(nullable: true),
                    productName = table.Column<string>(nullable: true),
                    productQty = table.Column<int>(nullable: false),
                    productPrice = table.Column<double>(nullable: false),
                    cartId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartItemActual", x => x.cartItemId);
                    table.ForeignKey(
                        name: "FK_CartItemActual_CartActual_cartId",
                        column: x => x.cartId,
                        principalTable: "CartActual",
                        principalColumn: "cartId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DeliberyItem",
                columns: table => new
                {
                    deliveryItemId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    productId = table.Column<string>(nullable: true),
                    productName = table.Column<string>(nullable: true),
                    productQty = table.Column<int>(nullable: false),
                    productPrice = table.Column<double>(nullable: false),
                    deliveryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeliberyItem", x => x.deliveryItemId);
                    table.ForeignKey(
                        name: "FK_DeliberyItem_Delivery_deliveryId",
                        column: x => x.deliveryId,
                        principalTable: "Delivery",
                        principalColumn: "deliveryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ReceiveItem",
                columns: table => new
                {
                    receiveItemId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    productId = table.Column<string>(nullable: true),
                    productName = table.Column<string>(nullable: true),
                    productQty = table.Column<int>(nullable: false),
                    productPrice = table.Column<double>(nullable: false),
                    receiveId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReceiveItem", x => x.receiveItemId);
                    table.ForeignKey(
                        name: "FK_ReceiveItem_Receive_receiveId",
                        column: x => x.receiveId,
                        principalTable: "Receive",
                        principalColumn: "receiveId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Branch_shoppingmallID",
                table: "Branch",
                column: "shoppingmallID");

            migrationBuilder.CreateIndex(
                name: "IX_CartActual_branchId",
                table: "CartActual",
                column: "branchId");

            migrationBuilder.CreateIndex(
                name: "IX_CartActual_shoppingmallID",
                table: "CartActual",
                column: "shoppingmallID");

            migrationBuilder.CreateIndex(
                name: "IX_CartItemActual_cartId",
                table: "CartItemActual",
                column: "cartId");

            migrationBuilder.CreateIndex(
                name: "IX_DeliberyItem_deliveryId",
                table: "DeliberyItem",
                column: "deliveryId");

            migrationBuilder.CreateIndex(
                name: "IX_Delivery_branchId",
                table: "Delivery",
                column: "branchId");

            migrationBuilder.CreateIndex(
                name: "IX_Delivery_shoppingmallID",
                table: "Delivery",
                column: "shoppingmallID");

            migrationBuilder.CreateIndex(
                name: "IX_Receive_branchId",
                table: "Receive",
                column: "branchId");

            migrationBuilder.CreateIndex(
                name: "IX_Receive_shoppingmallID",
                table: "Receive",
                column: "shoppingmallID");

            migrationBuilder.CreateIndex(
                name: "IX_ReceiveItem_receiveId",
                table: "ReceiveItem",
                column: "receiveId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CartItemActual");

            migrationBuilder.DropTable(
                name: "DeliberyItem");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "ReceiveItem");

            migrationBuilder.DropTable(
                name: "CartActual");

            migrationBuilder.DropTable(
                name: "Delivery");

            migrationBuilder.DropTable(
                name: "Receive");

            migrationBuilder.DropTable(
                name: "Branch");

            migrationBuilder.DropTable(
                name: "ShoppingMall");
        }
    }
}
