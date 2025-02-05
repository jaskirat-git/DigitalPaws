
using System.ComponentModel.DataAnnotations;
namespace Book_Management_Application.Validations
{
	public class UsernameValidation : ValidationAttribute
	{
		protected override ValidationResult IsValid(object value, ValidationContext validationContext)
		{
			var username = value?.ToString();

			if (string.IsNullOrEmpty(username))
			{
				ErrorMessage = "Username is required.";
				return new ValidationResult("Username is required.");
			}

			if (username.Length < 5 || username.Length > 20)
			{
				ErrorMessage = "Username must be between 5 and 20 characters.";
				return new ValidationResult("Username must be between 5 and 20 characters.");
			}

			return ValidationResult.Success;
		}
	}
}
