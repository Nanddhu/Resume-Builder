using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace ResumeBuilders.Models.Entities
{
    [Table("Users")]
    public class User
    {
        [Key]
        [Column("UserId")]

        public int UserId { get; set; }
        [Column("Name")]
        public string Name { get; set; } = null!;
        [Column("Email")]
        public string Email { get; set; } = null!;
        [Column("PasswordHash")]
        public string PasswordHash { get; set; } = null!;
        [Column("CreatedAt")]
        public DateTime CreatedAt { get; set; }
    }
}
