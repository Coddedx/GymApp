using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fitness.Web.Migrations
{
    public partial class MainPageNullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Trainers",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Trainers",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "AboutDescription",
                table: "MainPages",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AboutImageUrl1",
                table: "MainPages",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AboutImageUrl2",
                table: "MainPages",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AboutImageUrl3",
                table: "MainPages",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AboutRedirectUrl",
                table: "MainPages",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AboutTitle",
                table: "MainPages",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SliderImageUrl1",
                table: "MainPages",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SliderImageUrl2",
                table: "MainPages",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SliderImageUrl3",
                table: "MainPages",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SliderRedirectUrl1",
                table: "MainPages",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SliderRedirectUrl2",
                table: "MainPages",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SliderRedirectUrl3",
                table: "MainPages",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SliderSubtitle1",
                table: "MainPages",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SliderSubtitle2",
                table: "MainPages",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SliderSubtitle3",
                table: "MainPages",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SliderTitle1",
                table: "MainPages",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SliderTitle2",
                table: "MainPages",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SliderTitle3",
                table: "MainPages",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AboutDescription",
                table: "MainPages");

            migrationBuilder.DropColumn(
                name: "AboutImageUrl1",
                table: "MainPages");

            migrationBuilder.DropColumn(
                name: "AboutImageUrl2",
                table: "MainPages");

            migrationBuilder.DropColumn(
                name: "AboutImageUrl3",
                table: "MainPages");

            migrationBuilder.DropColumn(
                name: "AboutRedirectUrl",
                table: "MainPages");

            migrationBuilder.DropColumn(
                name: "AboutTitle",
                table: "MainPages");

            migrationBuilder.DropColumn(
                name: "SliderImageUrl1",
                table: "MainPages");

            migrationBuilder.DropColumn(
                name: "SliderImageUrl2",
                table: "MainPages");

            migrationBuilder.DropColumn(
                name: "SliderImageUrl3",
                table: "MainPages");

            migrationBuilder.DropColumn(
                name: "SliderRedirectUrl1",
                table: "MainPages");

            migrationBuilder.DropColumn(
                name: "SliderRedirectUrl2",
                table: "MainPages");

            migrationBuilder.DropColumn(
                name: "SliderRedirectUrl3",
                table: "MainPages");

            migrationBuilder.DropColumn(
                name: "SliderSubtitle1",
                table: "MainPages");

            migrationBuilder.DropColumn(
                name: "SliderSubtitle2",
                table: "MainPages");

            migrationBuilder.DropColumn(
                name: "SliderSubtitle3",
                table: "MainPages");

            migrationBuilder.DropColumn(
                name: "SliderTitle1",
                table: "MainPages");

            migrationBuilder.DropColumn(
                name: "SliderTitle2",
                table: "MainPages");

            migrationBuilder.DropColumn(
                name: "SliderTitle3",
                table: "MainPages");

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Trainers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(64)",
                oldMaxLength: 64);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Trainers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(64)",
                oldMaxLength: 64);
        }
    }
}
