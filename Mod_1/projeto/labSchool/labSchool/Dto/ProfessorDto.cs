﻿using System;
namespace labSchool.Dto
{
    // DTO PARA SAÍDA DE DADOS PARA O USÁRIO
    public class ProfessorSaidaDto
	{
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Cpf { get; set; }
        public string FormacaoAcademica { get; set; }
        public string Experiencia { get; set; }
        public string Estado { get; set; }
    }
}

