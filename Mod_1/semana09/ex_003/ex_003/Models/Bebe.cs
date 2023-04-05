using System;

namespace ex_003.Models
{
    public class Bebe
    {
        public int Id { get; set; }
        public DateTime Data_Nascimento { get; set; }
        public decimal Peso_Nascimento { get; set; }
        public int Altura { get; set; }
        public int Mae_Id { get; set; }
        public int Parto_Id { get; set; }

        // Foreign Key
        public virtual Mae Mae { get; set; }
        public virtual Parto Parto { get; set; }

    }
}

