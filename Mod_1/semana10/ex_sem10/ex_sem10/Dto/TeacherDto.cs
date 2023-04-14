using System;
namespace ex_sem10.Dto
{
	public class CreateTeacherDto
	{
        public string Departament { get; set; }
        public int User_id { get; set; }
    }

    public class UpdateTeacherDto
    {
        public string Departament { get; set; }
    }
}

