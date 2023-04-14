using System;
namespace ex_sem10.Models
{
	public class Student
	{
		public int Id { get; set; }
		public int Periodo { get; set; }
		public int Ra { get; set; }
		public int User_id { get; set; }

        // Foreign Key
        public virtual User User { get; set; }

        // Relação virtual
        public virtual ICollection<Answer> Answers { get; set; }
        public virtual ICollection<StudentDiscipline> Disciplines { get; set; }
    }

	


}

