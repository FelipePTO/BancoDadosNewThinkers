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
    public class ValuesController : ControllerBase
    {

        private readonly ILogger<ValuesController> _logger;
        private readonly IProdutoService _produto;

        public ValuesController(ILogger<ValuesController> logger, IProdutoService produto)
        {
            _logger = logger;
            _produto = produto;
        }



        // GET api/values
        [HttpGet]
        public ActionResult TodosOsProdutos()
        {
            return Ok(_produto.RetornarListadeProdutos());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> produto(int id)
        {
            return Ok(_produto.RetornarProdutopoId(id));
        }

        // POST api/values
        [HttpPost]
        public IActionResult ProdutoAdd([FromBody] Produto novoProduto)
        {
            return Ok(_produto.AdicionarProduto(novoProduto));
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public IActionResult AtualizarProduto(int id, [FromBody] Produto novoProduto)
        {
            return Ok(_produto.AtualizarProduto(novoProduto));

        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public IActionResult DeleteProduto(int id)
        {
            return Ok(_produto.DeletarProduto(id));
        }
    }
}
