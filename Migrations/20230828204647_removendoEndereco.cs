using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace conexaoemacao.Migrations
{
    public partial class removendoEndereco : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vagas_Enderecos_EnderecoId",
                table: "Vagas");

            migrationBuilder.DropIndex(
                name: "IX_Vagas_EnderecoId",
                table: "Vagas");

            migrationBuilder.DropColumn(
                name: "EnderecoId",
                table: "Vagas");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EnderecoId",
                table: "Vagas",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Vagas_EnderecoId",
                table: "Vagas",
                column: "EnderecoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vagas_Enderecos_EnderecoId",
                table: "Vagas",
                column: "EnderecoId",
                principalTable: "Enderecos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
