using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace conexaoemacao.Migrations
{
    public partial class TrocandooTipoTelefone : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Telefone",
                table: "Ongs",
                type: "character varying(13)",
                maxLength: 13,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer",
                oldMaxLength: 13);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Telefone",
                table: "Ongs",
                type: "integer",
                maxLength: 13,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(13)",
                oldMaxLength: 13);
        }
    }
}
