using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TurkiyeBolgelerSehirler.Migrations
{
    public partial class migo_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Slug",
                table: "Sehirler",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Slug",
                table: "Bolgeler",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Slug",
                table: "Sehirler");

            migrationBuilder.DropColumn(
                name: "Slug",
                table: "Bolgeler");
        }
    }
}
