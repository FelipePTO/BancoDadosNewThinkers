using Aula2.Bordas.Adapter;
using Aula2.DTO.Produto.AdicionarProduto;
using Aula2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula2.Adapter
{
    public class AdicionarProdutoAdapter : IAdicionarProdutoAdapter
    {
        public Produto converterRequestParaProduto(AdicionarProdutoRequest request)
        {
            var novoProduto = new Produto();
            novoProduto.nome = request.nome;
            novoProduto.valor = request.valor;
            novoProduto.descricao = request.descricao;
            return novoProduto;
        }
    }
}
