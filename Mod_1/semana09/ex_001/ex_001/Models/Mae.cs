using System;
namespace ex_001.Models
{
	public class Mae
	{
		public int Id { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public DateTime Data_Nascimento { get; set; }

        // Relação virtual
        public virtual ICollection<Bebe> Bebes { get; set; }
    }
}

