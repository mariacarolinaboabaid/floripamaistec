using System;
namespace ex_sem10.Dto
{
	public class QuizCreateDto
	{
        public string Title { get; set; }
        public DateTime Date_open { get; set; }
        public DateTime Date_close { get; set; }
        public int Discipline_id { get; set; }
    }

    public class QuizUpdateDto
    {
        public string Title { get; set; }
        public DateTime Date_open { get; set; }
        public DateTime Date_close { get; set; }
    }
}

