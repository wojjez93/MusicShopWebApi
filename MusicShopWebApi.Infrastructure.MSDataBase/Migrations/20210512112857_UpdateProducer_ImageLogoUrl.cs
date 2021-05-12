using Microsoft.EntityFrameworkCore.Migrations;

namespace MusicShopWebApi.Infrastructure.MSDataBase.Migrations
{
    public partial class UpdateProducer_ImageLogoUrl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageLogoUrl",
                table: "Producers",
                type: "nvarchar(2100)",
                maxLength: 2100,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageLogoUrl",
                table: "Producers");
        }
    }
}
