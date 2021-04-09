using Aula2.DTO.Produto.AdicionarProduto;
using Bogus;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aula2.Teste.Builder
{
    public class AdicionarProdutoRequestBuilder
    {
        private readonly Faker _faker = new Faker("pt_BR");
        private readonly AdicionarProdutoRequest _adicionarProduto;

        public AdicionarProdutoRequestBuilder()
        {
            _adicionarProduto = new AdicionarProdutoRequest();
            _adicionarProduto.nome = _faker.Random.String(40);
            _adicionarProduto.descricao = _faker.Random.String(40);
        }

        public AdicionarProdutoRequestBuilder withNameLength(int tamanho)
        {
            _adicionarProduto.nome = _faker.Random.String(tamanho);
            return this;
        }


        public AdicionarProdutoRequest Build()
        {
            return _adicionarProduto;
        }

    }
}
