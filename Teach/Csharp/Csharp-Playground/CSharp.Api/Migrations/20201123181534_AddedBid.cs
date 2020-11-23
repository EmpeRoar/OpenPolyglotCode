using Microsoft.EntityFrameworkCore.Migrations;

namespace CSharp.Api.Migrations
{
    public partial class AddedBid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BID",
                schema: "CX",
                table: "TestItem",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BID",
                schema: "CX",
                table: "TestItem");
        }
    }
}
