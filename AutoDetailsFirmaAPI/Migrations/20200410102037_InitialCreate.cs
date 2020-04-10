using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AutoDetailsFirmaAPI.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GroupOfDetails",
                columns: table => new
                {
                    GroupOfDetailId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArticleOfGroupOfDetail = table.Column<string>(maxLength: 7, nullable: true),
                    PriceOfGroupOfDetail = table.Column<double>(nullable: false),
                    NotesOfGroupOfDetail = table.Column<string>(maxLength: 25, nullable: true),
                    DataOfGroupOfDetail = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupOfDetails", x => x.GroupOfDetailId);
                });

            migrationBuilder.CreateTable(
                name: "Providers",
                columns: table => new
                {
                    ProviderId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProviderName = table.Column<string>(maxLength: 25, nullable: true),
                    ProviderAdress = table.Column<string>(maxLength: 50, nullable: true),
                    ProviderPhone = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Providers", x => x.ProviderId);
                });

            migrationBuilder.CreateTable(
                name: "Details",
                columns: table => new
                {
                    DetailId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GroupOfDetailId = table.Column<int>(nullable: false),
                    NameOfDetail = table.Column<string>(maxLength: 20, nullable: true),
                    ArticleOfDetail = table.Column<string>(maxLength: 7, nullable: true),
                    DataOfDetail = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Details", x => x.DetailId);
                    table.ForeignKey(
                        name: "FK_Details_GroupOfDetails_GroupOfDetailId",
                        column: x => x.GroupOfDetailId,
                        principalTable: "GroupOfDetails",
                        principalColumn: "GroupOfDetailId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Provides",
                columns: table => new
                {
                    ProvideId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdOFProvider = table.Column<int>(nullable: false),
                    IdOfDetail = table.Column<int>(nullable: false),
                    PriceOfProvide = table.Column<int>(nullable: false),
                    DataOfProvide = table.Column<DateTime>(nullable: false),
                    ArticleOfProvide = table.Column<string>(maxLength: 7, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Provides", x => x.ProvideId);
                    table.ForeignKey(
                        name: "FK_Provides_Providers_IdOFProvider",
                        column: x => x.IdOFProvider,
                        principalTable: "Providers",
                        principalColumn: "ProviderId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Provides_Details_IdOfDetail",
                        column: x => x.IdOfDetail,
                        principalTable: "Details",
                        principalColumn: "DetailId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Shops",
                columns: table => new
                {
                    ShopId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProvideId = table.Column<int>(nullable: false),
                    ArticleOfShop = table.Column<string>(maxLength: 7, nullable: true),
                    PriceOfShop = table.Column<double>(nullable: false),
                    NameOfShop = table.Column<string>(maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shops", x => x.ShopId);
                    table.ForeignKey(
                        name: "FK_Shops_Provides_ProvideId",
                        column: x => x.ProvideId,
                        principalTable: "Provides",
                        principalColumn: "ProvideId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Details_GroupOfDetailId",
                table: "Details",
                column: "GroupOfDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_Provides_IdOFProvider",
                table: "Provides",
                column: "IdOFProvider");

            migrationBuilder.CreateIndex(
                name: "IX_Provides_IdOfDetail",
                table: "Provides",
                column: "IdOfDetail");

            migrationBuilder.CreateIndex(
                name: "IX_Shops_ProvideId",
                table: "Shops",
                column: "ProvideId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Shops");

            migrationBuilder.DropTable(
                name: "Provides");

            migrationBuilder.DropTable(
                name: "Providers");

            migrationBuilder.DropTable(
                name: "Details");

            migrationBuilder.DropTable(
                name: "GroupOfDetails");
        }
    }
}
