using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Microsoft.Extensions.Logging;
using System.Linq;
using ShositoApp.Models;

namespace ShositoApp.Controllers
{
    [ApiController]
    public class pedidosController :ControllerBase
    {
        private readonly ShositoAppContext _contexto;

        public pedidosController(ShositoAppContext micontextoEnStartup) {
            this._contexto = micontextoEnStartup;
        }

        [HttpGet]
        [Route("api/listadoPedido")]
        public IEnumerable<pedidos> getListadoPedido()
        {                   
            IEnumerable<pedidos> listadoPedido = _contexto.pedidos;
            return listadoPedido;    

        }

        [HttpPost]
        [Route("api/guardarPedido")]
        public pedidos postAgregarPedido(pedidos _nuevoPedido){
            _contexto.pedidos.Add(_nuevoPedido);
            _contexto.SaveChanges();
            return _nuevoPedido;
        }


    }
}