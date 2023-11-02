using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace livrariaApi.models
{
    public class LivroAutor
    {
        [ForeignKey("Livros")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LivroId { get; set; }

        [ForeignKey("Autores")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AutorId { get; set; }

        public Livro? Livro { get; set; }
        public Autor? Autor { get; set; }
    }
}