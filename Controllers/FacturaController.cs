using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Microsoft.Extensions.Logging;
using System.Linq;
using TiendaApp.Models;

namespace TiendaApp.Controllers
{
    [ApiController]
    public class FacturaController :ControllerBase
    {
        private readonly TiendaAppContext _contexto;

        public FacturaController(TiendaAppContext micontextoEnStartup) {
            this._contexto = micontextoEnStartup;
        }

        [HttpGet]
        [Route("api/listadoFactura")]
        public IEnumerable<Factura> getListadoFactura()
        {                   
            IEnumerable<Factura> listadoFactura = _contexto.Factura;
            return  listadoFactura;    

        }


    }
}