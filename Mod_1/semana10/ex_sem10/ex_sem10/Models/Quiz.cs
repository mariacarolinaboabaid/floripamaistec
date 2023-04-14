using System;
namespace ex_sem10.Models
{
	public class Quiz
	{
		public int Id { get; set; }
		public string Title { get; set; }
		public DateTime Date_open { get; set; }
		public DateTime Date_close { get; set; }
		public int Discipline_id { get; set; }

		// Foreign Key
		public virtual Discipline Discipline { get; set; }

		// Relação virtual
		public virtual ICollection<Question> Questions { get; set; }

    }
}

