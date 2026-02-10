using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ResumeBuilders.Models.Entities
{
    [Table("skills")]
    public class Skill
    {
        [Key]
        [Column("ID")]
        public int ID { get; set; }

        [Column("SkillName")]
        public string SkillName { get; set; }

        [Column("CreatedAt")]
        public DateTime CreatedAt { get; set; }

        [Column("UpdatedAt")]
        public DateTime UpdatedAt { get; set; }
    }
}
