using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aula2.entities;

namespace aula2.services
{
    public interface ICategoriaService
    {

        bool AdicionarCategoria(Categoria categoria);
        List<Categoria> RetornarListadeCategoria();
        Produto RetornarCategoriaporId(int id);
        bool AtualizarCategoria(Categoria categoria);
        bool DeletarCategoria(int id);



    }
}
