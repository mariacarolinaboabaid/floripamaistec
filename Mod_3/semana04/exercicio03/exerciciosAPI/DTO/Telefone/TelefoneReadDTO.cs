using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using exerciciosAPI.Base;
using exerciciosAPI.DTO.Ficha;

namespace exerciciosAPI.DTO.Telefone
{
    public class TelefoneReadDTO
    {
        public int Id { get; set;}
        
        public string Contato { get; set; }
        
        public bool Ativo { get; set; }

        public FichaTelefoneReadDTO FichaTelefone {get; set; }
    }

    public class FichaTelefoneReadDTO : BaseDTO
    {
        public string Nome { get; set; }
        
    }
}