using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Dinozoico.Enum;

namespace Dinozoico.Models
{
    [Table("Dinossauros")]
    public class DinossauroModel 
    {
        [Display(Name = "Id")]
        [Column("Id")]
        public int Id { get; set; }
        [Display(Name = "Nome")]
        [Column("Nome")]
        public string Nome { get; set; }
        [Display(Name = "Altura")]
        [Column("Altura")]
        public double Altura { get; set; }
        [Display(Name = "Peso")]
        [Column("Peso")]
        public double Peso { get; set; }
        [Display(Name = "Alimentacao")]
        [Column("Alimentacao")]
        public Alimentacao Alimentacao { get; set; }
        [Display(Name = "Era")]
        [Column("Era")]
        public Era Era { get; set; }
    }
}
