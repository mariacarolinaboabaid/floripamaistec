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

        [Required]
        public int DDD { get; set; }

        [Required]
        public int Numero { get; set; }

        [Required]
        public bool Ativo { get; set; }

        // Relacionamento com FichaModel
        public virtual FichaModel Ficha { get; set; }
    }
}