using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace loja.Dto.Produto
{
    public class ProdutoCreateDTO
    {
        [Column(TypeName = "VARCHAR"), Required, StringLength(200, MinimumLength=3)]
        public string Nome {get; set;}

        [Required]
        public double Valor {get; set;}

        [Required]
        public DateTime DataValidade {get; set;}
    }
}