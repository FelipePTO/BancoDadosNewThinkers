using aula2.context;
using aula2.entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula2.services
{
    public class ProdutoService : IProdutoService
    {
        private readonly LocalDBContext _local;

        public ProdutoService(LocalDBContext local)
        {
            _local = local;
        }

        bool IProdutoService.AdicionarProduto(Produto produto)
        {
            _local.produto.Add(produto);
            _local.SaveChanges();
            return true;
        }

        bool IProdutoService.AtualizarProduto(Produto novoProduto)
        {
            _local.produto.Attach(novoProduto);
            _local.Entry(novoProduto).State = EntityState.Modified;
            _local.SaveChanges();
            return true;
        }

        bool IProdutoService.DeletarProduto(int id)
        {
            var objetoApagar = _local.produto.Where(d => d.id == id).FirstOrDefault();
            _local.produto.Remove(objetoApagar);
            _local.SaveChanges();
            return true;
        }

        List<Produto> IProdutoService.RetornarListadeProdutos()
        {
            return _local.produto.ToList();
        }

        Produto IProdutoService.RetornarProdutopoId(int id)
        {
            return _local.produto.Where(d => d.id == id).FirstOrDefault();
        }
    }
}
