using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace loja.Dto.Venda
{
    public class VendaCreateDTO
    {
        [Required]
        public int ProdutoId {get; set;}

        [Required]
        public int ClienteId  {get; set;}

        public double Desconto {get; set;}
    }
}