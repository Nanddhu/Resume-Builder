using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ResumeBuilders.Models.Entities.Stepper
{
   
        [Table("educations")]
        public class Education
        {
            [Key]
            [Column("ID")]
            public int ID { get; set; }

            [Column("ResumeID")]
            public int ResumeID { get; set; }

            [Column("Degree")]
            public string Degree { get; set; }

            [Column("Specialization")]
            public string Specialization { get; set; }  //stream

            [Column("Institute")]
            public string Institute { get; set; }

            // YEAR in MySQL → int? in C#
            [Column("StartYear")]
            public int? StartYear { get; set; } //from

            [Column("EndYear")]
            public int? EndYear { get; set; } //to

            [Column("CGPA")]
            public decimal? CGPA { get; set; }

            [Column("CreatedAt")]
            public DateTime CreatedAt { get; set; }

            [Column("UpdatedAt")]
            public DateTime UpdatedAt { get; set; }

            [Column("university")]
            public string university { get; set; }
        }
    
}
