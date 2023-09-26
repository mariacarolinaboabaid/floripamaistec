using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace loja.Dto.Cliente
{
    public class ClienteUpdateDTO
    {
        [Column(TypeName = "VARCHAR"), StringLength(200, MinimumLength=3)]
        public string Nome {get; set;}

        public double Saldo {get; set;}

    }
}