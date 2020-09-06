using System;
using Microsoft.EntityFrameworkCore;
/* 
            dotnet ef migrations add DbContextEXIWARE 
            dotnet ef database update 
*/
namespace EXIWARE.Models
{
public class DbContextEXIWARE : DbContext
{
    //
    //
    // TABLA SUCURSAL
    public DbSet<AdministradoresParams> ADMINISTRADORES { get; set; }
    //
    //
    // TABLA SUCURSAL
    public DbSet<SucursalParams> SUCURSALES { get; set; }
    //
    //
    // TABLA EMPLEADOS
    public DbSet<EmpleadosParams> EMPLEADOS { get; set; }
    //
    //
    // TABLA CLIENTES
    public DbSet<ClientesParams> CLIENTES { get; set; }
    //
    //
    // TABLA PRODUCTOS
    public DbSet<ProductosParams> PRODUCTOS { get; set; }
    //
    //
    // TABLA PEDIDOS
    public DbSet<PedidosParams> PEDIDOS { get; set; }
    //
    //
    // TABLA DETALLEPEDIDOS
    public DbSet<PedidoDetalleParams> DETALLEPEDIDOS { get; set; }
    //
    //
    //
    //
    /*  Configuración de la migración.
        Para la base de datos se usa la implementación en SQLite.
    */
    protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlite("Data Source=EXIWAREDBModel.db");
    public DbContextEXIWARE(DbContextOptions<DbContextEXIWARE> options) : base(options)
    {
        // COMPRUEBA QUE LA BD ESTÁ CREADA Y SI NO LA CREA.
        Database.EnsureCreated();
    }
    //
    //
}
}