using Aula2.Bordas.Repositorios;
using Aula2.DTO.Produto.RemoverProduto;
using Aula2.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula2.UseCase
{
    public class RemoverProdutoUseCase : IRemoverProdutoUseCase
    {
        private readonly IRepositorioProdutos _repositorioProdutos;

        public RemoverProdutoUseCase(IRepositorioProdutos repositorioProdutos)
        {
            _repositorioProdutos = repositorioProdutos;
        }

        public RemoverProdutoResponse Executar(RemoverProdutoRequest request)
        {
            var response = new RemoverProdutoResponse();
            try
            {                
                _repositorioProdutos.Remove(request.id);
                response.msg = "Removido com sucesso";
                return response;
            }
            catch(Exception e)
            {
                throw new System.Exception(e.Message);
            }            
        }

    }
}
