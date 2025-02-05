
using System.ComponentModel.DataAnnotations;
namespace DigitalPaws.Validations
{
	public class PasswordValidation : ValidationAttribute
	{
		protected override ValidationResult IsValid(object value, ValidationContext validationContext)
		{
			var password = value?.ToString();

			if (string.IsNullOrEmpty(password))
			{
				ErrorMessage = "Password is required.";
				return new ValidationResult("Password is required.");
			}

			if (password.Length < 8)
			{
				ErrorMessage = "Password must be at least 8 characters long.";
				return new ValidationResult("Password must be at least 8 characters long.");
			}

			bool hasUpperCase = false, hasNumber = false, hasSpecialChar = false;

			foreach (var ch in password)
			{
				if (char.IsUpper(ch)) hasUpperCase = true;
				if (char.IsDigit(ch)) hasNumber = true;
				if (!char.IsLetterOrDigit(ch)) hasSpecialChar = true;
			}

			if (!hasUpperCase)
			{
				ErrorMessage = "Password must contain at least one uppercase letter.";
				return new ValidationResult("Password must contain at least one uppercase letter.");
			}

			if (!hasNumber)
			{
				ErrorMessage = "Password must contain at least one number.";
				return new ValidationResult("Password must contain at least one number.");
			}

			if (!hasSpecialChar)
			{
				ErrorMessage = "Password must contain at least one special character.";
				return new ValidationResult("Password must contain at least one special character.");
			}

			return ValidationResult.Success;
		}
	}
}