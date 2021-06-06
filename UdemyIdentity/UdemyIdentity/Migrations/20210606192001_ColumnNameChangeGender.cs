using Microsoft.EntityFrameworkCore.Migrations;

namespace UdemyIdentity.Migrations
{
    public partial class ColumnNameChangeGender : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Cinsiyet",
                table: "AspNetUsers",
                newName: "Gender");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Gender",
                table: "AspNetUsers",
                newName: "Cinsiyet");
        }
    }
}
