using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TiendaApp.Models //Nombre del Proyecto.Nombre de carpeta
{
    public class Cliente
    {
  

        [Key]
        public int id_cliente { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string direccion { get; set; }
        public string fecha_nacimiento { get; set; }
        public string telefono { get; set; }
        public string email { get; set; }
    }
}