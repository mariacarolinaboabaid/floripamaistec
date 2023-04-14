using System;
namespace ex_sem10.Dto
{

	public class AnswerUpdateDto
    {
        public float Score { get; set; }
        public string Observation { get; set; }
    }

    public class AnswerCreateDto
    {
        public string Response { get; set; }
        public float Score { get; set; }
        public string Observation { get; set; }
        public int Student_id { get; set; }
        public int Question_id { get; set; }
    }
}

