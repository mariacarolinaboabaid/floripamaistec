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

        private readonly LabSchoolContext _context;

        public AlunoValidator(LabSchoolContext context)
		{
            _context = context;

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
                .WithMessage("O campo CPF possui preenchimento obrigatório")
                .Must(CPF_Unico)
                .WithMessage("O valor informado no campo CPF já existe.");

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

        // Verifica se há outro CPF de mesmo valor no banco de dados
        private bool CPF_Unico(string valor_cpf)
        {
            return !_context.Alunos.Any(x => x.Cpf == valor_cpf);
        }


        // Verifica se a situação da matrícula está com os valores admitidos
        private bool Valida_Situacao(string valor_situacao)
        {
            if (valor_situacao == "ATIVO" || valor_situacao == "IRREGULAR" || valor_situacao == "ATENDIMENTO"
                || valor_situacao == "ATENDIMENTO_PEDAGOGICO" || valor_situacao == "INATIVO")
                return false;
            else
                return true;
        }
    }
}

