using System;

namespace ex_003.Models
{
    public class Parto
    {
        public int Id { get; set; }
        public DateTime Data_Parto { get; set; }
        public TimeOnly Horario_Parto { get; set; }
        public int Medico_Id { get; set; }

        // Foreign Key
        public virtual Medico Medico { get; set; }

        // Relação virtual
        public virtual ICollection<Bebe> Bebes { get; set; }
    }
}

