using Microsoft.EntityFrameworkCore.Migrations;

namespace AutoDetailsFirmaAPI.Migrations
{
    public partial class afterIEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Details_GroupOfDetails_GroupOfDetailId",
                table: "Details");

            migrationBuilder.DropForeignKey(
                name: "FK_Provides_Providers_IdOFProvider",
                table: "Provides");

            migrationBuilder.DropForeignKey(
                name: "FK_Provides_Details_IdOfDetail",
                table: "Provides");

            migrationBuilder.DropForeignKey(
                name: "FK_Shops_Provides_ProvideId",
                table: "Shops");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Shops",
                table: "Shops");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Provides",
                table: "Provides");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Providers",
                table: "Providers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GroupOfDetails",
                table: "GroupOfDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Details",
                table: "Details");

            migrationBuilder.DropColumn(
                name: "ShopId",
                table: "Shops");

            migrationBuilder.DropColumn(
                name: "ProvideId",
                table: "Provides");

            migrationBuilder.DropColumn(
                name: "ProviderId",
                table: "Providers");

            migrationBuilder.DropColumn(
                name: "GroupOfDetailId",
                table: "GroupOfDetails");

            migrationBuilder.DropColumn(
                name: "DetailId",
                table: "Details");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Shops",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Provides",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Providers",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "GroupOfDetails",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Details",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Shops",
                table: "Shops",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Provides",
                table: "Provides",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Providers",
                table: "Providers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GroupOfDetails",
                table: "GroupOfDetails",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Details",
                table: "Details",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Details_GroupOfDetails_GroupOfDetailId",
                table: "Details",
                column: "GroupOfDetailId",
                principalTable: "GroupOfDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Provides_Providers_IdOFProvider",
                table: "Provides",
                column: "IdOFProvider",
                principalTable: "Providers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Provides_Details_IdOfDetail",
                table: "Provides",
                column: "IdOfDetail",
                principalTable: "Details",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Shops_Provides_ProvideId",
                table: "Shops",
                column: "ProvideId",
                principalTable: "Provides",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Details_GroupOfDetails_GroupOfDetailId",
                table: "Details");

            migrationBuilder.DropForeignKey(
                name: "FK_Provides_Providers_IdOFProvider",
                table: "Provides");

            migrationBuilder.DropForeignKey(
                name: "FK_Provides_Details_IdOfDetail",
                table: "Provides");

            migrationBuilder.DropForeignKey(
                name: "FK_Shops_Provides_ProvideId",
                table: "Shops");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Shops",
                table: "Shops");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Provides",
                table: "Provides");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Providers",
                table: "Providers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GroupOfDetails",
                table: "GroupOfDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Details",
                table: "Details");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Shops");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Provides");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Providers");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "GroupOfDetails");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Details");

            migrationBuilder.AddColumn<int>(
                name: "ShopId",
                table: "Shops",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "ProvideId",
                table: "Provides",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "ProviderId",
                table: "Providers",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "GroupOfDetailId",
                table: "GroupOfDetails",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "DetailId",
                table: "Details",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Shops",
                table: "Shops",
                column: "ShopId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Provides",
                table: "Provides",
                column: "ProvideId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Providers",
                table: "Providers",
                column: "ProviderId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GroupOfDetails",
                table: "GroupOfDetails",
                column: "GroupOfDetailId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Details",
                table: "Details",
                column: "DetailId");

            migrationBuilder.AddForeignKey(
                name: "FK_Details_GroupOfDetails_GroupOfDetailId",
                table: "Details",
                column: "GroupOfDetailId",
                principalTable: "GroupOfDetails",
                principalColumn: "GroupOfDetailId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Provides_Providers_IdOFProvider",
                table: "Provides",
                column: "IdOFProvider",
                principalTable: "Providers",
                principalColumn: "ProviderId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Provides_Details_IdOfDetail",
                table: "Provides",
                column: "IdOfDetail",
                principalTable: "Details",
                principalColumn: "DetailId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Shops_Provides_ProvideId",
                table: "Shops",
                column: "ProvideId",
                principalTable: "Provides",
                principalColumn: "ProvideId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
