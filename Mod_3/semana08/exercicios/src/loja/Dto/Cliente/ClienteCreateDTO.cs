using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace loja.Dto.Cliente
{
    public class ClienteCreateDTO
    {
        [Column(TypeName = "VARCHAR"), Required, StringLength(200, MinimumLength=3)]
        public string Nome {get; set;}

        [Required]
        public double Saldo {get; set;}
    }
}