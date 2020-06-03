using System;
using System.ComponentModel.DataAnnotations;

namespace AFI.Validators
{
    public class AgeValidator : ValidationAttribute
    {
        public AgeValidator(int age)
        {
            Age = age;
        }

        public int Age { get; }

        public string GetErrorMessage() =>
            $"User must be aged of {Age} years old.";

        protected override ValidationResult IsValid(object value,
            ValidationContext validationContext)
        {
            var userAge = ((DateTime)value);

            if (!CheckUserIsOverRequiredAge(Age, userAge))
            {
                return new ValidationResult(GetErrorMessage());
            }

            return ValidationResult.Success;
        }

        private bool CheckUserIsOverRequiredAge(int requiredAge, DateTime dob)
        {
            int age;
            age = DateTime.Now.Year - dob.Year;

            age -= Convert.ToInt32(DateTime.Now.Date < dob.Date.AddYears(age));

            return age >= requiredAge;
        }
    }
}
