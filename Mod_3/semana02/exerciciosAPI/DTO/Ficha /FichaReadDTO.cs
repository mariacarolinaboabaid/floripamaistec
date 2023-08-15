using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using exerciciosAPI.Base;
using exerciciosAPI.Enum;

namespace exerciciosAPI.DTO.Ficha
{
    public class FichaReadDTO
    {
        public string Nome { get; set; }

        public string Email { get; set; }

        public DateTime DataNascimento { get; set; }

        public IList<FichaDetalheReadDTO>? FichaComDetalhes { get; set; }
    }

    public class FichaDetalheReadDTO : BaseDTO
    {
        public EnumNota Nota { get; set; }
        
        public string Justificativa { get; set; }
    }
}
