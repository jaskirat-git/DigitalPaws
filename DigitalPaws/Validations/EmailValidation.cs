using System.ComponentModel.DataAnnotations;

namespace Book_Management_Application.Validations
{
	public class EmailValidation : ValidationAttribute
	{
		protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
		{
			if (value == null)
			{
				return new ValidationResult("Email cannot be null");
			}

			string email = value.ToString()!;

			// Spliting email by "@"
			string[] parts = email.Split('@');
			if (parts.Length != 2)
			{
				return new ValidationResult("Invalid email format: exactly one '@' symbol is required.");
			}

			// Validating domain 
			string domain = parts[1];
			string[] domainParts = domain.Split('.');
			if (domainParts.Length != 2)
			{
				return new ValidationResult("Invalid email format: a domain and extension are required.");
			}

			string provider = domainParts[0];
			string extension = domainParts[1];

			if (provider != "gmail" && provider != "yahoo" && provider != "outlook")
			{
				return new ValidationResult("Invalid email format: domain must be 'gmail', 'yahoo', or 'outlook'.");
			}

			if (extension != "com" && extension != "ca" && extension != "in")
			{
				return new ValidationResult("Invalid email format: extension must be 'com', 'ca', or 'in'.");
			}

			return ValidationResult.Success;
		}
	}
}
