using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ShositoApp.Models
{
    public class  pedidos
    {
        [Key]
        public int id_pedido { get; set; }
        public string categoria { get; set; }
        public string fecha { get; set; }
        public string talla { get; set; }        
        public string descripcion { get; set; }
        public int cantidad { get; set; }
        public string color{get; set;}
    }
}