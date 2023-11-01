using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace livrariaApi.models
{
    public class Livro
    {   [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID")]
        public int Id { get; set; }
        [Column("EDITORA")]
        public string? Editora { get; set; }
        [Column("EDICAO")]
        public int? Edicao { get; set; }
        [Column("ANO_PUBLICADO")]
        public string? AnoPublicado { get; set; }
        public List<LivroAssunto>? LivroAssuntos { get; set; }
        public List<LivroAutor>? LivroAutores { get; set; }
    }
}