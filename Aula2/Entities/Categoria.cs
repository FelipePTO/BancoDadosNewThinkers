using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Aula2.Entities
{
    public class Categoria
    {
        [Key]
        public int id { get; set; }
        public string categorianome { get; set; }
    }
}
