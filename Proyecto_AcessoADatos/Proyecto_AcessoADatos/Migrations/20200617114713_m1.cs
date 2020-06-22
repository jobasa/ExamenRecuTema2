using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Proyecto_AcessoADatos.Migrations
{
    public partial class m1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Eventos",
                columns: table => new
                {
                    EventoId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Equipo_Local = table.Column<string>(nullable: true),
                    Equipo_visitante = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Eventos", x => x.EventoId);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(nullable: true),
                    Apellido = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Edad = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Mercados",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    tipo_mercado = table.Column<string>(nullable: true),
                    Cuota_over = table.Column<decimal>(nullable: false),
                    Cuota_under = table.Column<decimal>(nullable: false),
                    Dinero_over = table.Column<float>(nullable: false),
                    Dinero_under = table.Column<float>(nullable: false),
                    IDEvento = table.Column<int>(nullable: false),
                    EventoId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mercados", x => x.id);
                    table.ForeignKey(
                        name: "FK_Mercados_Eventos_EventoId",
                        column: x => x.EventoId,
                        principalTable: "Eventos",
                        principalColumn: "EventoId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Cuentas",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Num_tarjeta_vinculada = table.Column<string>(nullable: true),
                    Saldo_actual = table.Column<decimal>(nullable: false),
                    Nombre_banco = table.Column<string>(nullable: true),
                    UsuarioId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cuentas", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Cuentas_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Apuestas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Dinero_apostado = table.Column<float>(nullable: false),
                    Cuota = table.Column<decimal>(nullable: false),
                    Tipo_apuesta = table.Column<string>(nullable: true),
                    ID_MERCADO = table.Column<int>(nullable: false),
                    ID_USUARIOS = table.Column<int>(nullable: false),
                    mercadoid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Apuestas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Apuestas_Mercados_mercadoid",
                        column: x => x.mercadoid,
                        principalTable: "Mercados",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Apuestas",
                columns: new[] { "Id", "Cuota", "Dinero_apostado", "ID_MERCADO", "ID_USUARIOS", "Tipo_apuesta", "mercadoid" },
                values: new object[] { 1, 3m, 100f, 1, 1, "Aouesta Over", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "EventoId", "Equipo_Local", "Equipo_visitante" },
                values: new object[] { 2, "Barcelona", "Madrid" });

            migrationBuilder.InsertData(
                table: "Mercados",
                columns: new[] { "id", "Cuota_over", "Cuota_under", "Dinero_over", "Dinero_under", "EventoId", "IDEvento", "tipo_mercado" },
                values: new object[] { 1, 3m, 2m, 4f, 4f, null, 2, "LigaSantander" });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "ID", "Apellido", "Edad", "Email", "Nombre" },
                values: new object[] { 2, "Jorda", 22, "pjorda96@gmail.com", "Pablo" });

            migrationBuilder.InsertData(
                table: "Cuentas",
                columns: new[] { "ID", "Nombre_banco", "Num_tarjeta_vinculada", "Saldo_actual", "UsuarioId" },
                values: new object[] { 2, "La Caixa", "5100001234567899", 200m, 2 });

            migrationBuilder.CreateIndex(
                name: "IX_Apuestas_mercadoid",
                table: "Apuestas",
                column: "mercadoid");

            migrationBuilder.CreateIndex(
                name: "IX_Cuentas_UsuarioId",
                table: "Cuentas",
                column: "UsuarioId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Mercados_EventoId",
                table: "Mercados",
                column: "EventoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Apuestas");

            migrationBuilder.DropTable(
                name: "Cuentas");

            migrationBuilder.DropTable(
                name: "Mercados");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Eventos");
        }
    }
}
