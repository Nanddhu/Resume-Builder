using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ResumeBuilders.Models.Entities;

namespace ResumeBuilders.Models.Entities
{
    [Table("Resumes")]
    public class Resume
    {
        [Key]
        [Column("ResumeId")]
        public int ResumeId { get; set; }

        [Column("UserId")]
        public int UserId { get; set; }


        [Column("FullName")]
        public string FullName { get; set; } = null!;

        [Column("Email")]
        public string Email { get; set; } = null!;

        [Column("PhoneNumber")]
        public string PhoneNumber { get; set; } = null!;

        [Column("City")]
        public string City { get; set; } = null!;

        [Column("State")]
        public string State { get; set; } = null!;

        [Column("LinkedInUrl")]
        public string LinkedInUrl { get; set; } = null!;

        [Column("GitHubUrl")]
        public string GitHubUrl { get; set; } = null!;

        [Column("Summary")]
        public string Summary { get; set; } = null!;

        [Column("CreatedAt")]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        [Column("UpdatedAt")]
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
        [Column]
        public string Created_by { get; set; } = null!;


        [ForeignKey("UserId")]
        public User User { get; set; }= null!;
    }
}
