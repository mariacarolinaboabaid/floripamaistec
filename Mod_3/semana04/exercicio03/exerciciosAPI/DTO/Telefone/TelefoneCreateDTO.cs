using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace exerciciosAPI.DTO.Telefone
{
    public class TelefoneCreateDTO
    {
        [Required(ErrorMessage = "Campo Obrigatório")]
        [StringLength(3, MinimumLength = 3, ErrorMessage ="Este campo precisa de 3 caracteres!")]
        public string DDD { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        [StringLength(9, MinimumLength = 9, ErrorMessage ="Este campo precisa de 9 caracteres!")]
        public string Numero { get; set; }
        
        [Required(ErrorMessage = "Campo Obrigatório")]
        public bool Ativo { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        public int FichaId { get; set; }

    }
}