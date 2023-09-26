using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace loja.Dto.Venda
{
    public class VendaReadDTO
    {
        public int Id {get; set;}

        public int ProdutoId {get; set;}

        public int ClienteId  {get; set;}

        public double Desconto {get; set;}
    }
}