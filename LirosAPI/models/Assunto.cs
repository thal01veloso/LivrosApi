using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace livrariaApi.models
{
    public class Assunto
    {   [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID")]
        public int Id { get; set; }
        [Column("DESCRICAO")]
        public string? Descricao { get; set; }
        public List<LivroAssunto>? LivroAssuntos { get; set; }
    }
}