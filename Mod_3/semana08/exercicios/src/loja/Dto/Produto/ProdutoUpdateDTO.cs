using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace loja.Dto.Produto
{
    public class ProdutoUpdateDTO
    {
        [Column(TypeName = "VARCHAR"), StringLength(200, MinimumLength=3)]
        public string Nome {get; set;}

        public double Valor {get; set;}

        public DateTime DataValidade {get; set;}
    }
}