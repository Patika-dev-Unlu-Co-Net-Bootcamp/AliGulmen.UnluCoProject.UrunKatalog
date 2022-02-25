using Microsoft.EntityFrameworkCore.Migrations;

namespace AliGulmen.UnluCoProject.UrunKatalog.Migrations
{
    public partial class offermodelupdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsAccepted",
                table: "Offers");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsAccepted",
                table: "Offers",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
