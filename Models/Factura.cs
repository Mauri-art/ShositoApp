using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TiendaApp.Models //Nombre del Proyecto.Nombre de carpeta
{
    public class Factura
    {
       
        [Key]
        public int id_factura { get; set; }
        public string num_factura { get; set; }
        public int id_cliente { get; set; } //FK
        public string fecha { get; set; }
        public int num_pago { get; set; }//FK
    
    }
}