using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LawyerSuits.Domain
{
    public class SuitItem : BaseEntity
    {
        [Required]
        [StringLength(255)]
        [Display(Name = "Suit Name")]
        public string SuitName { get; set; }
        [Display(Name = "Processo finalizado?")]
        public bool IsCompleted { get; set; } = false;// Lawsuit is finished
        
        [Display(Name = "Descrição do Processo")]
        public string SuitDescription { get; set; }
    }
}
