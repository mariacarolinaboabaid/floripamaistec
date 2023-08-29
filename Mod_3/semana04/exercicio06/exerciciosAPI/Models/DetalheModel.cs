using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using exerciciosAPI.Base;
using exerciciosAPI.Enum;

namespace exerciciosAPI.Models
{
    public class DetalheModel : BaseModel
    {
        [Column(TypeName = "VARCHAR"), Required, StringLength(500)]
        public string FeedBack { get; set; }

        [Required]
        public EnumNota Nota { get; set; }

        [Required]
        public bool Ativo { get; set; }

        // Foreign key
        [Required]
        public int FichaId { get; set; }

        // Relacionamento com FichaModel
        public virtual FichaModel Ficha { get; set;}

        public static implicit operator DetalheModel(List<DetalheModel> v)
        {
            throw new NotImplementedException();
        }
    }
}