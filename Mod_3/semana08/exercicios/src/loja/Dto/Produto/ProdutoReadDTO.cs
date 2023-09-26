using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using loja.Models;

namespace loja.Dto.Produto
{
    public class ProdutoReadDTO
    {
        public int Id {get; set;}

        public string Nome {get; set;}

        public double Valor {get; set;}

        public DateTime DataValidade {get; set;}

        public virtual IList<VendaModel> Vendas { get; set; }
    }
}