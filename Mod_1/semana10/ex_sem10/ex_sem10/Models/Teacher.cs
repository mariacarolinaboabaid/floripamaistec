using System;
namespace ex_sem10.Models
{
	public class Teacher
	{
		public int Id { get; set; }
		public string Departament { get; set; }
        public int User_id { get; set; }

		// Foreign Key
		public virtual User User { get; set; }

		// Relação virtual
		public virtual ICollection<Discipline> Disciplines { get; set; }
    }
}

