using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace livrariaApi.models
{
    public class LivroAssunto
    {
        
        
        [ForeignKey("livros")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LivroId { get; set; }

        [ForeignKey("assuntos")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AssuntoId { get; set; }

        public Livro? Livro { get; set; }
        public Assunto? Assunto { get; set; }
    }
}