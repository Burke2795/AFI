using AFI.Validators;
using Business.Validators;
using System;
using System.ComponentModel.DataAnnotations;

namespace Business.Models
{
    public class UserModel
    {
        [Required(ErrorMessage = "A forename is needed to create your user.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "The users forename needs to be between 3 and 50 characters")]
        public string Forename { get; set; }

        [Required(ErrorMessage = "A surname is needed to create your user.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "The users surname needs to be between 3 and 50 characters")]
        public string Surname { get; set; }

        [RegularExpression(@"^([a-z0-9]{4})@([-a-z0-9]{2})+(\.co.uk|\.com)$", ErrorMessage = "The email address needs to contain 4 alpha numerics followed by @ a minimum of 2 further alphanumberics then either .co.uk or .com eg. 'xxxx@xx.co.uk'")]
        public string Email { get; set; }

        [AgeValidator(18)]
        [CheckOneOfTwoPropertiesHasValue("DateOfBirth", "Email")]
        public DateTime? DateOfBirth { get; set; }
    }
}