using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace conexaoemacao.Migrations
{
    public partial class SegundCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CNPJ",
                table: "Ongs",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Segmento",
                table: "Ongs",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CNPJ",
                table: "Ongs");

            migrationBuilder.DropColumn(
                name: "Segmento",
                table: "Ongs");
        }
    }
}
