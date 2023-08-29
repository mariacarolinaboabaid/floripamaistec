using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace exerciciosAPI.Models
{
    public class TelefoneModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column(TypeName = "VARCHAR"), Required, StringLength(3)]
        public string DDD { get; set; }

        [Column(TypeName = "VARCHAR"), Required, StringLength(9)]
        public string Numero { get; set; }

        [Required]
        public bool Ativo { get; set; }

        // Foreign key
        [Required]
        public int FichaId { get; set; }

        // Relacionamento com FichaModel
        public virtual FichaModel Ficha { get; set; }
    }
}