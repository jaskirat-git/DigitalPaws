using System.ComponentModel.DataAnnotations;

namespace Book_Management_Application.Validations
{


	public class AgeValidation : ValidationAttribute
	{
		protected override ValidationResult IsValid(object value, ValidationContext validationContext)
		{
			if (value == null)
			{
				ErrorMessage = "Age is required.";
				return new ValidationResult("Age is required.");
			}

			if (int.TryParse(value.ToString(), out int age))
			{
				if (age < 1 || age > 120)
				{
					ErrorMessage = "Age must be between 1 and 120.";
					return new ValidationResult("Age must be between 1 and 120.");
				}

				return ValidationResult.Success;
			}

			return new ValidationResult("Invalid age value.");
		}
	}

}
