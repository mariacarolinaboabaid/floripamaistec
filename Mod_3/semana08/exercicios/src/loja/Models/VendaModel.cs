using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace loja.Models
{
    public class VendaModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id {get; set;}

        [Required]
        public int ProdutoId {get; set;}

        [Required]
        public int ClienteId  {get; set;}

        public double Desconto {get; set;}
        
        public virtual ProdutoModel Produto { get; set; }
        public virtual ClienteModel Cliente { get; set; }
    }
}