using aula2.context;
using aula2.entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula2.services
{
    public class CategoriaService : ICategoriaService
    {
        private readonly LocalDBContext _local;

        public CategoriaService(LocalDBContext local)
        {
            _local = local;
        }

        bool ICategoriaService.AdicionarCategoria(Categoria categoria)
        {
            _local.categoria.Add(categoria);
            _local.SaveChanges();
            return true;
        }

        bool ICategoriaService.AtualizarCategoria(Categoria novoCategoria)
        {
            _local.categoria.Attach(novoCategoria);
            _local.Entry(novoCategoria).State = EntityState.Modified;
            _local.SaveChanges();
            return true;
        }

        bool ICategoriaService.DeletarCategoria(int id)
        {
            var objetoApagar = _local.categoria.Where(d => d.id == id).FirstOrDefault();
            _local.categoria.Remove(objetoApagar);
            _local.SaveChanges();
            return true;
        }

        List<Categoria> ICategoriaService.RetornarListadeCategoria()
        {
            return _local.categoria.ToList();
        }

        Produto ICategoriaService.RetornarProdutopoId(int id)
        {
            return _local.produto.Where(d => d.id == id).FirstOrDefault();
        }
    }
}
