using Aula2.DTO.Produto.RetornarListadeProdutos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula2.UseCase
{
    public interface IRetornarListadeProdutosUseCase
    {
        RetornarListadeProdutosResponse Executar(RetornarListadeProdutosRequest request);
    }
}
