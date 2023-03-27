using System;
using Escola.Models;
using Microsoft.AspNetCore.Mvc;
using Escola.Dto;

namespace Escola.Repositories
{
    public class AlunosRepository
    {
        // Lista estática para os dados testes
        private static List<AlunoModel> lista = new List<AlunoModel>()
            {
             new AlunoModel {Id =  1, DataDeInclusao = new DateTime(2022, 03, 23), DataDeAlteracao = new DateTime(2023, 03, 23),
                 DataNascimento = new DateTime(1997, 10, 14), Nome = "Betânia Maria" },
             new AlunoModel {Id =  2, DataDeInclusao = new DateTime(2022, 04, 23), DataDeAlteracao = new DateTime(2023, 03, 23),
                 DataNascimento = new DateTime(2000, 05, 05), Nome = "Marcelo Luterino"},
             new AlunoModel {Id =  3, DataDeInclusao = new DateTime(2022, 08, 18), DataDeAlteracao = new DateTime(2023, 03, 23),
                 DataNascimento = new DateTime(1994, 02, 18), Nome = "Maria Regina Berger" },
             new AlunoModel {Id =  4, DataDeInclusao = new DateTime(2020, 10, 27), DataDeAlteracao = new DateTime(2023, 03, 23),
                 DataNascimento = new DateTime(2005, 07, 02), Nome = "Bernardo Rosa" },
            };

        // Método para listar os alunos com opção de passar 'nome' como parâmetro
        public List<AlunoModel> ListarAlunosRepository(string filtroNome)
        {
            if (string.IsNullOrEmpty(filtroNome))
            {
                return lista;
            }
            else
            {
                return lista.Where(x => x.Nome.ToUpper().Contains(filtroNome.ToUpper())).ToList();
            }
        }

        // Método para retornar disciplina por ID
        public AlunoModel ObterAlunoPorID(int id)
        {
            return lista.FirstOrDefault(x => x.Id == id);
        }

        // Método para criar disciplina
        public AlunoModel CriarAlunoRepository(CriacaoAlunoDto dto)
        {
            var aluno = new AlunoModel();
            aluno.Id = GerarID();
            aluno.Nome = dto.Nome;
            aluno.DataNascimento = dto.DataNascimento;
            aluno.DataDeAlteracao = dto.DataDeAlteracao;
            aluno.DataDeInclusao = dto.DataDeInclusao;
            lista.Add(aluno);
            return aluno;
        }

        // Método para gerar um ID
        private int GerarID()
        {
            return lista.Last().Id + 1;
        }
    }
}