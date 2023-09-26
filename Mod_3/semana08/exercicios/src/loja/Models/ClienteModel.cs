using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace loja.Models
{
    public class ClienteModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id {get; set;}

        [Column(TypeName = "VARCHAR"), Required, StringLength(200, MinimumLength=3)]
        public string Nome {get; set;}

        [Required]
        public double Saldo {get; set;}

        public virtual IList<VendaModel> Vendas { get; set; }
    }
}