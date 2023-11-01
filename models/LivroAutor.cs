using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace livrariaApi.models
{
   public class LivroAutor
   {
    [ForeignKey("Livro")]
    public int LivroId { get; set; }

    [ForeignKey("Autor")]
    public int AutorId { get; set; }

    public Livro? Livro { get; set; }
    public Autor? Autor { get; set; }
    }
}