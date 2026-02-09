using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ResumeBuilders.Models.Entities
{
    [Table("languages")]
    public class Language
    {
        [Key]
        [Column("ID")]
        public int ID { get; set; }

        [Column("LanguageName")]
        public string LanguageName { get; set; }

        [Column("CreatedAt")]
        public DateTime CreatedAt { get; set; }

        [Column("UpdatedAt")]
        public DateTime UpdatedAt { get; set; }
    }
}
