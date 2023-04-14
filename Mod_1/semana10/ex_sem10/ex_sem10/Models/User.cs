using System;
namespace ex_sem10.Models
{
	public class User
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Email { get; set; }
		public string Cpf { get; set; }
		public string Password { get; set; }

		// Relação virtual
		public virtual Student Student { get; set; }
        public virtual Teacher Teacher { get; set; }
    }
}

