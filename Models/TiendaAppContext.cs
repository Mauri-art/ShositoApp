using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using System.Collections.Generic;
//using System.Data.Entity;
namespace TiendaApp.Models
{
    public  class TiendaAppContext : DbContext
    {
        public TiendaAppContext(DbContextOptions<TiendaAppContext> options):base(options)
        {
        }
        public DbSet<Categoria> Categoria {get;set;}
        public DbSet<Cliente> Cliente {get;set;}
        public DbSet<Detalle> Detalle {get;set;}
        public DbSet<Factura> Factura {get;set;}
        public DbSet<Modo_Pago> Modo_Pago {get;set;}
        public DbSet<Producto> Producto {get;set;}




    }
}