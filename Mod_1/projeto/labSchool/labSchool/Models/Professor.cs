using System;
namespace labSchool.Models
{
    // CLASSE PROFESSOR COM HERANÇA DA CLASSE PESSOA
    public class Professor : Pessoa
	{
		public string FormacaoAcademica { get; set; }
		public string Experiencia { get; set; }
		public string Estado { get; set; }
	}
}

