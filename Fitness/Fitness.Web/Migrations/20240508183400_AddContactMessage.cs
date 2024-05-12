using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fitness.Web.Migrations
{
    public partial class AddContactMessage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Mail",
                table: "ContactMessages",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Mail",
                table: "ContactMessages");
        }
    }
}
