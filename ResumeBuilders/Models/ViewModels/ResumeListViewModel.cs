using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using ResumeBuilders.Models.Entities;

namespace ResumeBuilders.Models.ViewModels
{
  
    public class ResumeListViewModel
    {
        [Required]
        public int ResumeId { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; } = null!;   
        [Required]
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        [Required]
        [StringLength(100)]
        public string CreatedBy { get; set; } = null!;
    }
  
}
