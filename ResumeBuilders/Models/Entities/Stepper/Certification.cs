using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ResumeBuilders.Models.Entities.Stepper
{
    [Table("certifications")]
    public class Certification
    {
        [Key]
        [Column("ID")]
        public int ID { get; set; }

        [Column("ResumeID")]
        public int ResumeID { get; set; }

        [Column("Title")]
        public string Title { get; set; }

        [Column("IssuedBy")]
        public string IssuedBy { get; set; }

        // YEAR in MySQL → int?
        [Column("IssuedYear")]
        public int? IssuedYear { get; set; }

        [Column("CertificateUrl")]
        public string CertificateUrl { get; set; }

        [Column("CreatedAt")]
        public DateTime CreatedAt { get; set; }

        [Column("UpdatedAt")]
        public DateTime UpdatedAt { get; set; }

        [Column("ExpiryDate")]
        public DateTime ExpiryDate { get; set; }
    }
}
