using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ResumeBuilders.Models.Entities.Stepper
{
    [Table("resumeskills")]
    public class ResumeSkill
    {
        [Key]
        [Column("ID")]
        public int ID { get; set; }

        [Column("ResumeID")]
        public int ResumeID { get; set; }

        [Column("SkillID")]
        public int SkillID { get; set; }

        [Column("CreatedAt")]
        public DateTime CreatedAt { get; set; }

        [Column("UpdatedAt")]
        public DateTime UpdatedAt { get; set; }

        [Column("SkillName")]
        public string SkillName { get; set; }
    }
}
