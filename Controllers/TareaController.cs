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
    public class TareaController : ControllerBase
    {
        private readonly ILogger<TareaController> _logger;
        ITareaServices tareaService;

        public TareaController(ILogger<TareaController> logger, ITareaServices tarea)
        {
            _logger = logger;
            tareaService = tarea;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(tareaService.Get());
        }

        [HttpPost]
        public IActionResult Post([FromBody] Tarea tarea)
        {
            tareaService.save(tarea);
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult Put(Guid id, [FromBody] Tarea tarea)
        {
            tareaService.update(id, tarea);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult delete(Guid id)
        {
            tareaService.Delete(id);
            return Ok();
        }

    }
}