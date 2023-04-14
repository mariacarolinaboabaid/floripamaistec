using System;
namespace ex_sem10.Models
{
	public class Answer
	{
		public int Id { get; set; }
		public string Response { get; set; }
		public float Score { get; set; }
		public string Observation { get; set; }
		public int Student_id { get; set; }
		public int Question_id { get; set; }

        // Foreign Key
        public virtual Student Student  { get; set; }
		public virtual Question Question { get; set; }

    }
}

