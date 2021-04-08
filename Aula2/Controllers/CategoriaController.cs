using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aula2.entities;
using Microsoft.Extensions.Logging;
using aula2.services;

namespace aula2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {

        private readonly ILogger<CategoriaController> _logger;
        private readonly ICategoriaService _categoria;

        public CategoriaController(ILogger<CategoriaController> logger, ICategoriaService categoria)
        {
            _logger = logger;
            _categoria = categoria;
        }



        // GET api/values
        [HttpGet]
        public ActionResult TodosAsCategorias()
        {
            return Ok(_categoria.RetornarListadeCategoria());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> categoria(int id)
        {
            return Ok(_categoria.RetornarCategoriaporId(id));
        }

        // POST api/values
        [HttpPost]
        public IActionResult ProdutoAdd([FromBody] Categoria novoCategoria)
        {
            return Ok(_categoria.AdicionarCategoria(novoCategoria));
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public IActionResult AtualizarProduto(int id, [FromBody] Categoria novoCategoria)
        {
            return Ok(_categoria.AtualizarCategoria(novoCategoria));

        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public IActionResult DeleteProduto(int id)
        {
            return Ok(_categoria.DeletarCategoria(id));
        }
    }
}
