using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TiendaApp.Models
{
    public class Detalle
    {
        
        [Key]
        public int num_detalle { get; set; }
        public int id_factura { get; set; }
        
        public int id_producto { get; set; }
        public int cantidad { get; set; }
        public decimal precio { get; set; }

    }
}