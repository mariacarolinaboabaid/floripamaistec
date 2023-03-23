using System;
namespace Escola.Models
{

	// Criação da classe abstrata
	public abstract class BaseModel
	{
        // Atributos
        public int Id { get; set; }
        public DateTime DataDeInclusao { get; set; }
        public DateTime DataDeAlteracao { get; set; }
    }
}

