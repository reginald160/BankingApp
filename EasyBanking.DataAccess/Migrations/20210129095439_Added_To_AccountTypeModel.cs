using Microsoft.EntityFrameworkCore.Migrations;

namespace EasyBanking.DataAccess.Migrations
{
    public partial class Added_To_AccountTypeModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            

            migrationBuilder.AddColumn<string>(
                name: "AccountCode",
                table: "AccountTypes",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "AccountTypes",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AccountCode",
                table: "AccountTypes");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "AccountTypes");

          
        }
    }
}
