using Aula2.Bordas.Adapter;
using Aula2.Bordas.Repositorios;
using Aula2.DTO.Produto.AdicionarProduto;
using Aula2.Entities;
using Aula2.Teste.Builder;
using Aula2.UseCase;
using FluentAssertions;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Aula2.Teste.UseCase
{
    public class AdicionarProdutoUseCaseTest
    {
        private readonly Mock<IRepositorioProdutos> _repositorioProdutos;
        private readonly Mock<IAdicionarProdutoAdapter> _adicionarProdutosAdapter;
        private readonly AdicionarProdutoUseCase _usecase;

        public AdicionarProdutoUseCaseTest()
        {
            _repositorioProdutos = new Mock<IRepositorioProdutos>();
            _adicionarProdutosAdapter = new Mock<IAdicionarProdutoAdapter>();
            _usecase = new AdicionarProdutoUseCase(
                _repositorioProdutos.Object,
                _adicionarProdutosAdapter.Object
            );
        }

        [Fact]
        public void Produto_AdicionarProduto_QuantoRetonarSucesso()
        {
            //Arrange
            var request = new AdicionarProdutoRequestBuilder().Build();
            var respose = new AdicionarProdutoResponse();
            var produto = new Produto();
            produto.id = 1;

            respose.msg = "Produto adicionado com sucesso";
            respose.id = produto.id;

            _repositorioProdutos.Setup(repositorio => repositorio.Add(produto)).Returns(produto.id);
            _adicionarProdutosAdapter.Setup(adapter => adapter.converterRequestParaProduto(request)).Returns(produto);

            //Act
            var result = _usecase.Executar(request);

            //Assert
            respose.Should().BeEquivalentTo(result);
        }

        [Fact]
        public void Produto_AdicionarProduto_QuantoNomeMenorVinte()
        {
            //Arrange
            var request = new AdicionarProdutoRequestBuilder().withNameLength(10).Build();
            var respose = new AdicionarProdutoResponse();
            //var produto = new Produto();
            //produto.id = 1;

            respose.msg = "Erro ao adicionar o produto";

            //_repositorioProdutos.Setup(repositorio => repositorio.Add(produto)).Returns(produto.id);
            //_adicionarProdutosAdapter.Setup(adapter => adapter.converterRequestParaProduto(request)).Returns(produto);

            //Act
            var result = _usecase.Executar(request);

            //Assert
            respose.Should().BeEquivalentTo(result);
        }

        [Fact]
        public void Produto_AdicionarProduto_QuantoRepositorioExcecao()
        {
            //Arrange
            var request = new AdicionarProdutoRequestBuilder().Build();
            var respose = new AdicionarProdutoResponse();
            var produto = new Produto();
            produto.id = 1;
            respose.msg = "Erro ao adicionar o produto";
            _adicionarProdutosAdapter.Setup(adapter => adapter.converterRequestParaProduto(request)).Returns(produto);
            _repositorioProdutos.Setup(repositorio => repositorio.Add(produto)).Throws(new Exception());

            //Act
            var result = _usecase.Executar(request);

            //Assert
            respose.Should().BeEquivalentTo(result);
        }


    }
}
