using System;
using Escola.Models;

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
    }
}