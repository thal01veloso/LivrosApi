using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace livrariaApi.models
{
    public class Autor
    {   [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID")]
        public int Id { get; set; }
        [Column("NOME")]
        public string? Nome { get; set; }
        public List<LivroAutor>? LivroAutores { get; set; }
    }
}