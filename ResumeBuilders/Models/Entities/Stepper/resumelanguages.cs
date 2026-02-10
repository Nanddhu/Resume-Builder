using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ResumeBuilders.Models.Entities.Stepper
{
    [Table("resumelanguages")]
    public class ResumeLanguage
    {
        [Key]
        [Column("ID")]
        public int ID { get; set; }

        [Column("ResumeID")]
        public int ResumeID { get; set; }

        [Column("LanguageName")]
        public string LanguageName { get; set; }

        [Column("CreatedAt")]
        public DateTime CreatedAt { get; set; }

        [Column("UpdatedAt")]
        public DateTime UpdatedAt { get; set; }
    }
}
