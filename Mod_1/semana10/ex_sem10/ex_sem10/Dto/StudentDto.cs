using System;
namespace ex_sem10.Dto
{
	public class StudentCreateDto
	{
        public int Periodo { get; set; }
        public int Ra { get; set; }
        public int User_id { get; set; }
    }

    public class StudentUpateDto
    {
        public int Periodo { get; set; }
        public int Ra { get; set; }
    }
}

