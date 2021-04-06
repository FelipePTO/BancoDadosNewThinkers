using Aula2.Context;
using Aula2.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula2.Services
{
    public class ProdutoService : IProdutoService
    {

        private readonly LocalDbContext _local;

        public ProdutoService(LocalDbContext local)
        {
            _local = local;
        }

        public bool AdicionarProduto(Produto produto)
        {
            _local.produto.Add(produto);
            _local.SaveChanges();
            return true;
        }

        public bool AtualizarProduto(Produto novoProduto)
        {
            _local.produto.Attach(novoProduto);
            _local.Entry(novoProduto).State = EntityState.Modified;
            _local.SaveChanges();
            return true;
        }

        public bool DeletarProduto(int id)
        {
            var objApagar = _local.produto.Where(d => d.id == id).FirstOrDefault();
            _local.produto.Remove(objApagar);
            _local.SaveChanges();
            return true;
        }

        public List<Produto> RetonarListaProduto()
        {
            return _local.produto.ToList();
        }

        public Produto RetornarProdutoPorId(int id)
        {
            return _local.produto.Where(d => d.id == id).FirstOrDefault();
        }
    }
}
