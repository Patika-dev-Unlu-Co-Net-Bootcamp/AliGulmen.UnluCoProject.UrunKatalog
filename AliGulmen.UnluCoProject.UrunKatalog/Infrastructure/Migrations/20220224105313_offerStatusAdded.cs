using Microsoft.EntityFrameworkCore.Migrations;

namespace AliGulmen.UnluCoProject.UrunKatalog.Migrations
{
    public partial class offerStatusAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OfferStatus",
                table: "Offers",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OfferStatus",
                table: "Offers");
        }
    }
}
