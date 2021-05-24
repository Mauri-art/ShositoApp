using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Microsoft.Extensions.Logging;
using System.Linq;
using TiendaApp.Models;

namespace TiendaApp.Controllers
{
    [ApiController]
    public class Modo_PagoController :ControllerBase
    {
        private readonly TiendaAppContext _contexto;

        public Modo_PagoController(TiendaAppContext micontextoEnStartup) {
            this._contexto = micontextoEnStartup;
        }

        [HttpGet]
        [Route("api/listadoModo_Pago")]
        public IEnumerable<Modo_Pago> getListadoModo_Pago()
        {                   
            IEnumerable<Modo_Pago> listadoModo_Pago = _contexto.Modo_Pago;
            return  listadoModo_Pago;    

        }


    }
}