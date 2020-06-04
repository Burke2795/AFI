using System.ComponentModel.DataAnnotations;

namespace Business.Validators
{
    public class CheckOneOfTwoPropertiesHasValue : ValidationAttribute
    {
        public CheckOneOfTwoPropertiesHasValue(string property1, string property2)
        {
            Property1 = property1;
            Property2 = property2;
        }

        public string Property1 { get; }
        public string Property2 { get; }

        public string GetErrorMessage() =>
            $"At least one of {Property1} or {Property2} is required";

        protected override ValidationResult IsValid(object value,
            ValidationContext validationContext)
        {

            var prop1Value = validationContext.ObjectType.GetProperty(Property1).GetValue(validationContext.ObjectInstance, null);
            var prop2Value = validationContext.ObjectType.GetProperty(Property2).GetValue(validationContext.ObjectInstance, null);

            if (prop1Value == null && prop2Value == null)
            {
                return new ValidationResult(GetErrorMessage());
            }

            return ValidationResult.Success;
        }
    }
}
