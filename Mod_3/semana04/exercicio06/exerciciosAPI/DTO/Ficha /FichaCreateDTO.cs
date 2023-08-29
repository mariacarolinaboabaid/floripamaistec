using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace exerciciosAPI.DTO.Ficha 
{
    public class FichaCreateDTO
    {
        [Required(ErrorMessage = "Campo Obrigatório")]
        [MaxLength(500, ErrorMessage = "Este campo aceita até 500 caracteres")]
        [MinLength(5, ErrorMessage = "Favor digitar o nome completo")]
        public string NomeCompleto { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        [Display(Name = "E-mail")]
        [EmailAddress(ErrorMessage = "Email Inválido")]
        public string EmailInformado { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        [Range(typeof(DateTime), "1950-01-01", "2100-12-31", ErrorMessage = "Invalid date")]
        public DateTime DataDeNascimento { get; set; }
    }
}