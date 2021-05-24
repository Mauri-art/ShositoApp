using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace ShositoApp.Models
{
    public class ShositoAppContext:DbContext
    {
        public ShositoAppContext(DbContextOptions<ShositoAppContext> options):base(options)
        {
				

        }

        //Listado de tablas
        public DbSet<pedidos> pedidos{get; set;}
    }
}