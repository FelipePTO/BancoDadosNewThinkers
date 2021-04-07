using Aula2.DTO.Produto.AdicionarProduto;
using Aula2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula2.Bordas.Adapter
{
    public interface IAdicionarProdutoAdapter
    {
        public Produto converterRequestParaProduto(AdicionarProdutoRequest request);
    }
}
