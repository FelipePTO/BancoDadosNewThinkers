using Aula2.Bordas.Repositorios;
using Aula2.Context;
using Aula2.DTO.Produto.AdicionarProduto;
using Aula2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula2.Repositorios
{
    public class RepositorioProdutos : IRepositorioProdutos
    {
        private readonly LocalDbContext _local;

        public RepositorioProdutos(LocalDbContext local)
        {
            _local = local;
        }

        public int Add(Produto request)
        {
            _local.produto.Add(request);
            _local.SaveChanges();
            return request.id;
        }

        public void Remove(int id)
        {
            var obj = _local.produto.Where(d => d.id == id).FirstOrDefault();
            if (obj == null)
            {
                throw new System.Exception();
            }
            _local.produto.Remove(obj);
            _local.SaveChanges();
        }
    }
}
