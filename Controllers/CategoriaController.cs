using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using webapi.Models;
using webapi.Services;

namespace webapi.Controllers
{
    [Route("api/[controller]")]
    public class CategoriaController : ControllerBase
    {
        private readonly ILogger<CategoriaController> _logger;
        ICategoriaServices categoriaService;

        public CategoriaController(ILogger<CategoriaController> logger, ICategoriaServices categoria)
        {
            _logger = logger;
            categoriaService = categoria;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(categoriaService.Get());
        }

        [HttpPost]
        public IActionResult Post([FromBody] Categoria categoria)
        {
            categoriaService.save(categoria);
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult Put(Guid id, [FromBody] Categoria categoria)
        {
            categoriaService.update(id, categoria);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult delete(Guid id)
        {
            categoriaService.Delete(id);
            return Ok();
        }

    }
}