using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Microsoft.Extensions.Logging;
using System.Linq;
using TiendaApp.Models;

namespace TiendaApp.Controllers
{
    [ApiController]
    public class ProductoController :ControllerBase
    {
        private readonly TiendaAppContext _contexto;

        public ProductoController(TiendaAppContext micontextoEnStartup) {
            this._contexto = micontextoEnStartup;
        }

        [HttpGet]
        [Route("api/listadoProducto")]
        public IEnumerable<Producto> getListadoProducto()
        {                   
            IEnumerable<Producto> listadoProducto = _contexto.Producto;
            return  listadoProducto;    

        }


    }
}