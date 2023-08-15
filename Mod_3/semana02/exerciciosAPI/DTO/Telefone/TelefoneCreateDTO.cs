using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exerciciosAPI.DTO.Telefone
{
    public class TelefoneCreateDTO
    {
        public int DDD { get; set; }

        public int Numero { get; set; }

        public bool Ativo { get; set; }

    }
}