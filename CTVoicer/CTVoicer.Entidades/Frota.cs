using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CTVoicer.Entidades
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
