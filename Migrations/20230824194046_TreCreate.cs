using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace conexaoemacao.Migrations
{
    public partial class TreCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MensagemdeDescr",
                table: "Voluntarios",
                type: "text",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MensagemdeDescr",
                table: "Voluntarios");
        }
    }
}
