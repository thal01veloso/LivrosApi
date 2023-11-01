using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace livrariaApi.models
{
    public class LivroAssunto
{
    [ForeignKey("Livro")]
    public int LivroId { get; set; }

    [ForeignKey("Assunto")]
    public int AssuntoId { get; set; }

    public Livro? Livro { get; set; }
    public Assunto? Assunto { get; set; }
}
}