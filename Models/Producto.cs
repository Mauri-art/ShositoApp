using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TiendaApp.Models
{
    public class Producto
    {

        [Key]
        public int id_producto { get; set; }
        public string nombre { get; set; }
        public decimal precio { get; set; }
        public int  stock { get; set; }
        public int id_categoria { get; set; }

    }    
}