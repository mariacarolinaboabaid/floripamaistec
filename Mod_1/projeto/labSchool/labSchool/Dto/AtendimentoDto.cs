using System;
using System.ComponentModel.DataAnnotations;

namespace labSchool.Dto
{
    // DTO ENTRADA DADOS PARA ATUALIZAÇÃO DO ATENDIMENTO
    public class AtendimentoEntradaDto
    {
        [Required()]
        public int CodigoAluno { get; set; }
        [Required()]
        public int CodigoPedagogo { get; set; }
    }
}

