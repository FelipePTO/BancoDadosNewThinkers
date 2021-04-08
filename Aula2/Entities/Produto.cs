using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace aula2.entities
{
    public class Categoria
    {
        [Key]
        public int id { get; set; }

        public String nome { get; set; }

       

    }
}
