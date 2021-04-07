using Aula2.DTO.Produto.RemoverProduto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula2.UseCase
{
    public interface IRemoverProdutoUseCase
    {
        RemoverProdutoResponse Executar(RemoverProdutoRequest request);
    }
}
