using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TiendaApp.Models
{
    public class Categoria
    {
        
        [Key]
        public int id_categoria { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }

    }    
}