using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace kafer_house.Migrations
{
    public partial class innnit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(maxLength: 25, nullable: false),
                    LastName = table.Column<string>(maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CarPlate",
                columns: table => new
                {
                    carPlateId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    carPlateNumber = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarPlate", x => x.carPlateId);
                });

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
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RoleId = table.Column<int>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<int>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false),
                    RoleId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Manager",
                columns: table => new
                {
                    ManagerId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(maxLength: 25, nullable: true),
                    LastName = table.Column<string>(maxLength: 25, nullable: true),
                    ApplicationUserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manager", x => x.ManagerId);
                    table.ForeignKey(
                        name: "FK_Manager_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Staff",
                columns: table => new
                {
                    StaffId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(maxLength: 25, nullable: true),
                    LastName = table.Column<string>(maxLength: 25, nullable: true),
                    ApplicationUserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staff", x => x.StaffId);
                    table.ForeignKey(
                        name: "FK_Staff_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    carPlateId = table.Column<int>(nullable: false),
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
                        name: "FK_Delivery_CarPlate_carPlateId",
                        column: x => x.carPlateId,
                        principalTable: "CarPlate",
                        principalColumn: "carPlateId",
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
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

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
                name: "IX_Delivery_carPlateId",
                table: "Delivery",
                column: "carPlateId");

            migrationBuilder.CreateIndex(
                name: "IX_Delivery_shoppingmallID",
                table: "Delivery",
                column: "shoppingmallID");

            migrationBuilder.CreateIndex(
                name: "IX_Manager_ApplicationUserId",
                table: "Manager",
                column: "ApplicationUserId",
                unique: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_Staff_ApplicationUserId",
                table: "Staff",
                column: "ApplicationUserId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "CartItemActual");

            migrationBuilder.DropTable(
                name: "DeliberyItem");

            migrationBuilder.DropTable(
                name: "Manager");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "ReceiveItem");

            migrationBuilder.DropTable(
                name: "Staff");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "CartActual");

            migrationBuilder.DropTable(
                name: "Delivery");

            migrationBuilder.DropTable(
                name: "Receive");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "CarPlate");

            migrationBuilder.DropTable(
                name: "Branch");

            migrationBuilder.DropTable(
                name: "ShoppingMall");
        }
    }
}
