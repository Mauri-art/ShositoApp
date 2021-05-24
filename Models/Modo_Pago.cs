using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TiendaApp.Models //Nombre del Proyecto.Nombre de carpeta
{
    public class Modo_Pago
    {

        
        [Key]
        public int num_pago { get; set; }
        public string nombre { get; set; }
        public string otros_detalles { get; set; }


    }
}