using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class Frota
    {
        [Key]
        public int IdFrota { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(250)")]
        public string Nome { get; set; }

        public virtual List<Veiculo> Veiculos { get; set; }
    }
}
