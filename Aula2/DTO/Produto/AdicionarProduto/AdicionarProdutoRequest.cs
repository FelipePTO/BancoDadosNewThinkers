using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula2.DTO.Produto.AdicionarProduto
{
    public class AdicionarProdutoRequest
    {
        public string nome { get; set; }
        public string descricao { get; set; }
        public int valor { get; set; }
    }
}
