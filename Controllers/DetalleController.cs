using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Microsoft.Extensions.Logging;
using System.Linq;
using TiendaApp.Models;

namespace TiendaApp.Controllers
{
    [ApiController]
    public class DetalleController :ControllerBase
    {
        private readonly TiendaAppContext _contexto;

        public DetalleController(TiendaAppContext micontextoEnStartup) {
            this._contexto = micontextoEnStartup;
        }

        [HttpGet]
        [Route("api/ListadoDetalle")]
        public IEnumerable<Detalle> getListadoCliente()
        {                   
            IEnumerable<Detalle> listadoDetalle = _contexto.Detalle;
            return listadoDetalle;    

        }

    }
}