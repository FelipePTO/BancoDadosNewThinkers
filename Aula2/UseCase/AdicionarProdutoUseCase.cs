using Aula2.Bordas.Adapter;
using Aula2.Bordas.Repositorios;
using Aula2.DTO.Produto.AdicionarProduto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula2.UseCase
{
    public class AdicionarProdutoUseCase : IAdicionarProdutoUseCase
    {
        private readonly IRepositorioProdutos _repositorioProdutos;
        private readonly IAdicionarProdutoAdapter _adapter;

        public AdicionarProdutoUseCase(IRepositorioProdutos repositorioProdutos, 
                                        IAdicionarProdutoAdapter adapter)
        {
            _repositorioProdutos = repositorioProdutos;
            _adapter = adapter;
        }

        public AdicionarProdutoResponse Executar(AdicionarProdutoRequest request)
        {
            var response = new AdicionarProdutoResponse();

            try
            {
                if (request.nome.Length < 20)
                {
                    response.msg = "Erro ao adicionar o produto";
                    return response;
                }

                var produtoAdicionar = _adapter.converterRequestParaProduto(request);
                var id = _repositorioProdutos.Add(produtoAdicionar);
                response.msg = "Produto adicionado com sucesso";
                response.id = produtoAdicionar.id;
                return response;
            }
            catch
            {
                response.msg = "Erro ao adicionar o produto";
                return response;
            }
            
        }
    }
}
