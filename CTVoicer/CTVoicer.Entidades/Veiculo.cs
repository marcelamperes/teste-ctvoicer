using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CTVoicer.Entidades
{
    public class Veiculo
    {
        [Key]
        public int IdVeiculo { get; set; }

        [Required]
        public int IdFrota { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(17)")]
        public string Chassi { get; set; }

        [Required]
        [Column(TypeName = "varchar(10)")]
        public string Tipo { get; set; }
        //public TipoVeiculoEnum Tipo { get; set; }

        [Required]
        [Column(TypeName = "byte")]
        public byte NumPassageiros { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string Cor { get; set; }

        [ForeignKey("IdFrota")]
        public virtual Frota Frota { get; set; }
    }
}
