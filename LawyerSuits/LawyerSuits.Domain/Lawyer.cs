using LawyerSuits.Domain.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LawyerSuits.Domain
{
    public class Lawyer : BaseEntity
    {
        [Required]
        [StringLength(255)]
        [Display(Name = "Nome do Advogado")]
        public string LawyerName { get; set; }
        [Display(Name = "CPF")]
        [Required]
        [StringLength(255)]
        public string LawyerCPF { get; set; }

        [Display(Name = "Número de Ordem OAB")]
        [Required]
        [StringLength(255)]
        public string LawyerOABOrder { get; set; }

        [Display(Name = "Área de Ocupação")]
        [Required]
        [EnumDataType(typeof(LawyerOccupationArea))]
        public LawyerOccupationArea OccupationArea { get; set; }
        [Display(Name = "Pode Exercer?")]
        public bool IsActive { get; set; } = false;// Lawyer has the to right to exercise his profession

    }
}
