using Aula2.DTO.Produto.RetornarProdutoPorId;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula2.UseCase
{
    public interface IRetornarProdutosPorIdUseCase
    {
        RetornarProdutoPorIdResponse Executar(RetornarProdutoPorIdRequest request);
    }
}
