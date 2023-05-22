using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TesteCamposDealerBackend.Migrations
{
    /// <inheritdoc />
    public partial class CreateTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    idCliente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nmCliente = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    cidade = table.Column<string>(type: "Text", unicode: false, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.idCliente);
                });

            migrationBuilder.CreateTable(
                name: "Produtos",
                columns: table => new
                {
                    idProduto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    dscProduto = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    vlrUnitario = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produtos", x => x.idProduto);
                });

            migrationBuilder.CreateTable(
                name: "Vendas",
                columns: table => new
                {
                    idVenda = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idCliente = table.Column<int>(type: "int", nullable: false),
                    idProduto = table.Column<int>(type: "int", nullable: false),
                    qtdVenda = table.Column<int>(type: "int", nullable: false),
                    vlrUnitarioVenda = table.Column<float>(type: "real", nullable: false),
                    dthVenda = table.Column<DateTime>(type: "datetime2", nullable: false),
                    vlrTotalVenda = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendas", x => x.idVenda);
                    table.ForeignKey(
                        name: "FK_Vendas_Clientes_idCliente",
                        column: x => x.idCliente,
                        principalTable: "Clientes",
                        principalColumn: "idCliente");
                    table.ForeignKey(
                        name: "FK_Vendas_Produtos_idProduto",
                        column: x => x.idProduto,
                        principalTable: "Produtos",
                        principalColumn: "idProduto");
                });

            migrationBuilder.InsertData(
                table: "Clientes",
                columns: new[] { "idCliente", "cidade", "nmCliente" },
                values: new object[,]
                {
                    { 1, "Cidade1", "Cli1" },
                    { 2, "Cidade2", "Cli2" },
                    { 3, "Cidade3", "Cli3" },
                    { 4, "Cidade4", "Cli4" }
                });

            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "idProduto", "dscProduto", "vlrUnitario" },
                values: new object[,]
                {
                    { 1, "Produto 1", 5f },
                    { 2, "Produto 2", 10f },
                    { 3, "Produto 3", 15f },
                    { 4, "Produto 4", 20f }
                });

            migrationBuilder.InsertData(
                table: "Vendas",
                columns: new[] { "idVenda", "dthVenda", "idCliente", "idProduto", "qtdVenda", "vlrTotalVenda", "vlrUnitarioVenda" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 5, 21, 22, 11, 38, 731, DateTimeKind.Utc), 1, 1, 5, 0f, 5f },
                    { 2, new DateTime(2023, 5, 21, 22, 11, 38, 731, DateTimeKind.Utc), 1, 2, 1, 0f, 10f },
                    { 3, new DateTime(2023, 5, 21, 22, 11, 38, 731, DateTimeKind.Utc), 1, 3, 1, 0f, 15f },
                    { 4, new DateTime(2023, 5, 21, 22, 11, 38, 731, DateTimeKind.Utc), 2, 1, 5, 0f, 5f },
                    { 5, new DateTime(2023, 5, 21, 22, 11, 38, 731, DateTimeKind.Utc), 2, 2, 1, 0f, 10f },
                    { 6, new DateTime(2023, 5, 21, 22, 11, 38, 731, DateTimeKind.Utc), 3, 1, 10, 0f, 6f },
                    { 7, new DateTime(2023, 5, 21, 22, 11, 38, 731, DateTimeKind.Utc), 3, 3, 2, 0f, 15f }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Vendas_idCliente",
                table: "Vendas",
                column: "idCliente");

            migrationBuilder.CreateIndex(
                name: "IX_Vendas_idProduto",
                table: "Vendas",
                column: "idProduto");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Vendas");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Produtos");
        }
    }
}
