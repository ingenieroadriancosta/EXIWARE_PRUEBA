using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EXIWARE.Migrations
{
    public partial class DbContextEXIWARE : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ADMINISTRADORES",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Id_card = table.Column<long>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Phone = table.Column<long>(nullable: false),
                    Password = table.Column<string>(nullable: true),
                    SesionValue = table.Column<string>(nullable: true),
                    SesionState = table.Column<bool>(nullable: false),
                    State = table.Column<bool>(nullable: false),
                    SuperAdmin = table.Column<bool>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ADMINISTRADORES", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CLIENTES",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Id_card = table.Column<long>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Lastname = table.Column<string>(nullable: true),
                    State = table.Column<bool>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CLIENTES", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DETALLEPEDIDOS",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    IdSucursal = table.Column<long>(nullable: false),
                    IdCard_E = table.Column<long>(nullable: false),
                    IdCard_C = table.Column<long>(nullable: false),
                    IdDetalle = table.Column<long>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DETALLEPEDIDOS", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EMPLEADOS",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    IdCard = table.Column<long>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Lastname = table.Column<string>(nullable: true),
                    Phone = table.Column<long>(nullable: false),
                    Password = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EMPLEADOS", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PEDIDOS",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    IdSucursal = table.Column<long>(nullable: false),
                    IdCard_E = table.Column<long>(nullable: false),
                    IdCard_C = table.Column<long>(nullable: false),
                    IdDetalle = table.Column<long>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PEDIDOS", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PRODUCTOS",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    Stock = table.Column<long>(nullable: false),
                    Product_code = table.Column<long>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PRODUCTOS", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SUCURSALES",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    IdSucursal = table.Column<long>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Phone = table.Column<long>(nullable: false),
                    Address = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SUCURSALES", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ADMINISTRADORES");

            migrationBuilder.DropTable(
                name: "CLIENTES");

            migrationBuilder.DropTable(
                name: "DETALLEPEDIDOS");

            migrationBuilder.DropTable(
                name: "EMPLEADOS");

            migrationBuilder.DropTable(
                name: "PEDIDOS");

            migrationBuilder.DropTable(
                name: "PRODUCTOS");

            migrationBuilder.DropTable(
                name: "SUCURSALES");
        }
    }
}
