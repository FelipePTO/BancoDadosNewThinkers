using Aula2.DTO.Produto.AdicionarProduto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula2.UseCase
{
    public interface IAdicionarProdutoUseCase
    {
        AdicionarProdutoResponse Executar(AdicionarProdutoRequest request);
    }
}
