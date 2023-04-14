using System;
namespace labSchool.Models
{
    // Classe Professor herdando da classe Pessoa
    public class Professor : Pessoa
	{
		public string FormacaoAcademica { get; set; }
		public string Experiencia { get; set; }
		public string Estado;
	}
}

