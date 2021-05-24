using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Microsoft.Extensions.Logging;
using System.Linq;
using TiendaApp.Models;

namespace TiendaApp.Controllers
{
    [ApiController]
    public class CategoriaController :ControllerBase
    {
        private readonly TiendaAppContext _contexto;

        public CategoriaController(TiendaAppContext micontextoEnStartup) {
            this._contexto = micontextoEnStartup;
        }

        [HttpGet]
        [Route("api/listadoCategoria")]
        public IEnumerable<Categoria> getListadoCategoria()
        {                   
            IEnumerable<Categoria> listadoCategoria = _contexto.Categoria;
            return listadoCategoria;    

        }

    }
}