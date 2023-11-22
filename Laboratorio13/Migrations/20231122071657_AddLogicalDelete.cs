using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Laboratorio13.Migrations
{
    public partial class AddLogicalDelete : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Grade",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Course",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Grade");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Course");
        }
    }
}
