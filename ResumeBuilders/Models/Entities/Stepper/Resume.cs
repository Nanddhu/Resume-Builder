using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ResumeBuilders.Models.Entities.Stepper
{
  
    public class Resume
    {
        [Key]
        [Column("ID")]
        public int ID { get; set; }

        [Column("UserID")]
        public int UserID { get; set; }

        [Column("AreYou")]
        public string AreYou { get; set; }

        [Column("FirstName")]
        public string FirstName { get; set; }

        [Column("LastName")]
        public string LastName { get; set; }

        [Column("Email")]
        public string Email { get; set; }

        [Column("Phonenumber")]
        public string PhoneNumber { get; set; }

        [Column("DOB")]
        public DateTime? DOB { get; set; }

        [Column("City")]
        public string City { get; set; }

        [Column("State")]
        public string State { get; set; }

        [Column("LinkedInUrl")]
        public string LinkedInUrl { get; set; }

        [Column("ProjectUrl")]
        public string ProjectUrl { get; set; }

        [Column("Objective")]
        public string Objective { get; set; }

        [Column("Hobbies")]
        public string Hobbies { get; set; }

        [Column("Achievements")]
        public string Achievements { get; set; }

        [Column("CreatedAt")]
        public DateTime CreatedAt { get; set; }

        [Column("UpdatedAt")]
        public DateTime UpdatedAt { get; set; }
        public User User { get; set; }

    }

}
