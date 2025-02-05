using System.ComponentModel.DataAnnotations;

namespace Book_Management_Application.Validations
{

	public class DateOfBirthValidation : ValidationAttribute
	{
		protected override ValidationResult IsValid(object value, ValidationContext validationContext)
		{
			if (value == null)
			{
				ErrorMessage = "Date of Birth is required.";
				return new ValidationResult("Date of Birth is required.");
			}

			if (DateTime.TryParse(value.ToString(), out DateTime dob))
			{
				if (dob > DateTime.Now)
				{
					ErrorMessage = "Date of Birth cannot be in the future.";
					return new ValidationResult("Date of Birth cannot be in the future.");
				}

				if (DateTime.Now.Year - dob.Year > 120)
				{
					ErrorMessage = "Date of Birth suggests an age greater than 120.";
					return new ValidationResult("Date of Birth suggests an age greater than 120.");
				}

				return ValidationResult.Success;
			}

			return new ValidationResult("Invalid Date of Birth.");
		}
	}

}
