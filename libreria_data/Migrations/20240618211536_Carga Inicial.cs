using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace libreria_data.Migrations
{
    /// <inheritdoc />
    public partial class CargaInicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RolesUser",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RolesUser", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TransaccionesLibro",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaTransaccion = table.Column<DateTime>(type: "datetime", nullable: false),
                    FechaRegreso = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransaccionesLibro", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Libros",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    titulo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    trama = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    hojas = table.Column<int>(type: "int", nullable: false),
                    numLibros = table.Column<int>(type: "int", nullable: false),
                    soloUsers = table.Column<int>(type: "int", nullable: false),
                    TransaccionesLibroid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Libros", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Libros_TransaccionesLibro_TransaccionesLibroid",
                        column: x => x.TransaccionesLibroid,
                        principalTable: "TransaccionesLibro",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    password = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    RolesUserId = table.Column<int>(type: "int", nullable: true),
                    TransaccionesLibroid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                    table.ForeignKey(
                        name: "FK_User_RolesUser_RolesUserId",
                        column: x => x.RolesUserId,
                        principalTable: "RolesUser",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_User_TransaccionesLibro_TransaccionesLibroid",
                        column: x => x.TransaccionesLibroid,
                        principalTable: "TransaccionesLibro",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Clasificaciones",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LibrosId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clasificaciones", x => x.id);
                    table.ForeignKey(
                        name: "FK_Clasificaciones_Libros_LibrosId",
                        column: x => x.LibrosId,
                        principalTable: "Libros",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Impuesto",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LibrosId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Impuesto", x => x.id);
                    table.ForeignKey(
                        name: "FK_Impuesto_Libros_LibrosId",
                        column: x => x.LibrosId,
                        principalTable: "Libros",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Personas",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    APaterno = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AMaterno = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    TransaccionesLibroid = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personas", x => x.id);
                    table.ForeignKey(
                        name: "FK_Personas_TransaccionesLibro_TransaccionesLibroid",
                        column: x => x.TransaccionesLibroid,
                        principalTable: "TransaccionesLibro",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_Personas_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Rol",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    RolesUserId = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rol", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rol_RolesUser_RolesUserId",
                        column: x => x.RolesUserId,
                        principalTable: "RolesUser",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Rol_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Clasificaciones_LibrosId",
                table: "Clasificaciones",
                column: "LibrosId");

            migrationBuilder.CreateIndex(
                name: "IX_Impuesto_LibrosId",
                table: "Impuesto",
                column: "LibrosId");

            migrationBuilder.CreateIndex(
                name: "IX_Libros_TransaccionesLibroid",
                table: "Libros",
                column: "TransaccionesLibroid");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_TransaccionesLibroid",
                table: "Personas",
                column: "TransaccionesLibroid");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_UserId",
                table: "Personas",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Rol_RolesUserId",
                table: "Rol",
                column: "RolesUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Rol_UserId",
                table: "Rol",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_User_RolesUserId",
                table: "User",
                column: "RolesUserId");

            migrationBuilder.CreateIndex(
                name: "IX_User_TransaccionesLibroid",
                table: "User",
                column: "TransaccionesLibroid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clasificaciones");

            migrationBuilder.DropTable(
                name: "Impuesto");

            migrationBuilder.DropTable(
                name: "Personas");

            migrationBuilder.DropTable(
                name: "Rol");

            migrationBuilder.DropTable(
                name: "Libros");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "RolesUser");

            migrationBuilder.DropTable(
                name: "TransaccionesLibro");
        }
    }
}
