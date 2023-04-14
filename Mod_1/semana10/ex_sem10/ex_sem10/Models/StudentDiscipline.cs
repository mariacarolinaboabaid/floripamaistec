using System;
namespace ex_sem10.Models
{
	public class StudentDiscipline
	{
		public int Id { get; set; }
		public int Student_id { get; set; }
		public int Discipline_id { get; set; }

		// Foreign Key
		public virtual Student Student { get; set; }
        public virtual Discipline Discipline { get; set; }
    }
}

