using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Microsoft.Extensions.Logging;
using System.Linq;
using TiendaApp.Models;

namespace TiendaApp.Controllers
{
    [ApiController]
    public class ClienteController :ControllerBase
    {
        private readonly TiendaAppContext _contexto;

        public ClienteController(TiendaAppContext micontextoEnStartup) {
            this._contexto = micontextoEnStartup;
        }

        [HttpGet]
        [Route("api/listadoCliente")]
        public IEnumerable<Cliente> getListadoCliente()
        {                   
            IEnumerable<Cliente> listadoCliente = _contexto.Cliente;
            return listadoCliente;    

        }

    }
}