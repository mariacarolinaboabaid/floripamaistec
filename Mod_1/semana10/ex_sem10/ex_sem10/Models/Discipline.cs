using System;
namespace ex_sem10.Models
{
	public class Discipline
	{
		public int Id { get; set; }
		public string Discipline_name { get; set; }
		public int Teacher_id { get; set; }

		// Foreign Key
		public virtual Teacher Teacher { get; set; }

        // Relação virtual
        public virtual ICollection<StudentDiscipline> Students { get; set; }
		public virtual ICollection<Quiz> Quizzes { get; set; }

    }
}

