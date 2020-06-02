using System;
using System.ComponentModel.DataAnnotations;

namespace Data.Entities
{
    public class Users
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Forename { get; set; }

        [Required]
        public string Surname { get; set; }

        [Required]
        [StringLength(9)]
        public string ReferenceNumber { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public string Email { get; set; }
    }
}
