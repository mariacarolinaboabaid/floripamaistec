using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using exerciciosAPI.Base;

namespace exerciciosAPI.Models
{
    public class FichaModel : BaseModel
    {
        [Column(TypeName = "VARCHAR"), Required, StringLength(200)]
        public string Nome { get; set;}

        [Column(TypeName = "VARCHAR"), Required, StringLength(200)]
        public string Email { get; set; }

        [Required]
        public DateTime DataNascimento {get; set; }

        // Relacionamento com DetalheModel
        public virtual IList<DetalheModel> Detalhes { get; set; }

        // Relacionamento com TelefoneModel
        public virtual IList<TelefoneModel> Telefones { get; set; }
    }
}