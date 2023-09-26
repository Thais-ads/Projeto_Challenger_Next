using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API_ARTCHER.Migrations
{
    /// <inheritdoc />
    public partial class cadastrocontex : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Filiais",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    NomeDaFilial = table.Column<string>(type: "NVARCHAR2(30)", maxLength: 30, nullable: false),
                    Contato = table.Column<string>(type: "NVARCHAR2(30)", maxLength: 30, nullable: false),
                    Endereco = table.Column<string>(type: "NVARCHAR2(30)", maxLength: 30, nullable: false),
                    Numero = table.Column<int>(type: "NUMBER(10)", maxLength: 30, nullable: false),
                    Bairro = table.Column<string>(type: "NVARCHAR2(30)", maxLength: 30, nullable: false),
                    Descricao = table.Column<string>(type: "NVARCHAR2(200)", maxLength: 200, nullable: false),
                    Foto = table.Column<string>(type: "NVARCHAR2(30)", maxLength: 30, nullable: false),
                    Data = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Filiais", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Nome = table.Column<string>(type: "NVARCHAR2(30)", maxLength: 30, nullable: false),
                    Email = table.Column<string>(type: "NVARCHAR2(30)", maxLength: 30, nullable: false),
                    Usuario = table.Column<string>(type: "NVARCHAR2(30)", maxLength: 30, nullable: false),
                    Senha = table.Column<string>(type: "NVARCHAR2(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Filiais");

            migrationBuilder.DropTable(
                name: "Usuario");
        }
    }
}
