using System;
using FluentValidation;
using labSchool.Models;
using labSchool.Context;
using labSchool.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace labSchool.Validators
{
	public class AlunoValidator : AbstractValidator<Aluno>
    {
       
        public AlunoValidator()
		{
            //_context = context;

			RuleFor(x => x.Nome).NotEmpty()
				.NotNull()
				.WithMessage("O campo NOME possui preenchimento obrigatório")
				.Length(2, 150).WithMessage("O campo NOME deve possuir no mínimo 2 e no máximo 150 caracteres.");

			RuleFor(x => x.Telefone).NotEmpty()
				.NotNull()
				.WithMessage("O campo TELEFONE possui preenchimento obrigatório.");

            RuleFor(x => x.DataNascimento).NotEmpty()
                .NotNull()
                .WithMessage("O campo DATA DE NASCIMENTO possui preenchimento obrigatório.");

            RuleFor(x => x.Cpf).NotEmpty()
                .NotNull()
                .WithMessage("O campo CPF possui preenchimento obrigatório");

            RuleFor(x => x.SituacaoMatricula).NotEmpty()
                .NotNull()
                .WithMessage("O campo SITUAÇÃO MATRÍCULA possui preenchimento obrigatório.")
                .Must(Valida_Situacao).
                WithMessage("O campo SITUAÇÃO MATRÍCULA apenas aceita os seguintes valores: 'ATIVO', 'IRREGULAR', 'ATENDIMENTO', 'ATENDIMENTO_PEDAGOGICO' e 'INATIVO'.");

            RuleFor(x => x.NotaProcessoSeletivo).NotEmpty()
                .NotNull()
                .WithMessage("O campo NOTA possui preenchimento obrigatório.")
                .InclusiveBetween(0,10)
                .WithMessage("O campo NOTA somente aceita valores entre 0 a 10.");

        }

        
        // VERIFICA SE A SITUAÇÃO DA MATRÍCULA ESTÁ COM VALORES ADMITIDOS
        private bool Valida_Situacao(string valor_situacao)
        {
            if (valor_situacao == "ATIVO" || valor_situacao == "IRREGULAR" || valor_situacao == "ATENDIMENTO"
                || valor_situacao == "ATENDIMENTO_PEDAGOGICO" || valor_situacao == "INATIVO")
                return true;
            else
                return false;
        }
    }
}

