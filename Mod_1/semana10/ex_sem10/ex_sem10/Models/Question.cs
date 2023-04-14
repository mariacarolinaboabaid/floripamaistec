using System;
namespace ex_sem10.Models
{
    public class Question
    {
        public int Id { get; set; }
        public string Enunciation { get; set; }
        public decimal Weight { get; set; }
        public int Quiz_id { get; set; }

        // Foreign Key
        public virtual Quiz Quiz { get; set; }

        // Relação virtual
        public virtual ICollection<Answer> Answers { get; set; }
    }
}

