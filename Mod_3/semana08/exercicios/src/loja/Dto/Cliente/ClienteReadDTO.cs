using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using loja.Models;

namespace loja.Dto.Cliente
{
    public class ClienteReadDTO
    {
        public int Id {get; set;}

        public string Nome {get; set;}

        public double Saldo {get; set;}

        public virtual IList<VendaModel> Vendas { get; set; }
    }
}