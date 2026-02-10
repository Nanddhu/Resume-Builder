using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ResumeBuilders.Models.Entities.Stepper
{
    public class Projects
    {

        [Key]
        [Column("ID")]
        public int ID { get; set; }

        [Column("ResumeID")]
        public int ResumeID { get; set; }

        [Column("CompanyName")]
        public string CompanyName { get; set; } 

        [Column("ProjectTitle")]
        public string ProjectTitle { get; set; } = null!;



        [Column("Role")]
        public string Role { get; set; }

        [Column("Description")]
        public string Description { get; set; } = null!;


        [Column("ProjectLink")]
        public string ProjectLink { get; set; }

        [Column("Technologies")]
        public string Technologies { get; set; }= null!;

        [Column("StartDate")]
        public DateTime? StartDate { get; set; }

        [Column("EndDate")]
        public DateTime? EndDate { get; set; }

        [Column("CreatedAt")]
        public DateTime CreatedAt { get; set; }

        [Column("UpdatedAt")]
        public DateTime UpdatedAt { get; set; }
    }
}
