using System;
using System.ComponentModel.DataAnnotations;

namespace Data.Entities
{
    public class Users
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Forename { get; set; }

        [Required]
        [StringLength(50)]
        public string Surname { get; set; }

        [Required]
        [StringLength(9)]
        public string ReferenceNumber { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public string Email { get; set; }

        public bool Online { get; set; }
    }
}
