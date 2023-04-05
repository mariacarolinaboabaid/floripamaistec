using System;
namespace ex_001.Models
{
	public class Medico
	{
		public int Id { get; set; }
		public string Crm { get; set; }
        public string Nome { get; set; }
        public int Celular { get; set; }
        public string Especialidade { get; set; }


        // Relação virtual
        public virtual ICollection<Parto> Partos { get; set; }
    }
}

