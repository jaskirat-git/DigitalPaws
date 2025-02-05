using System.ComponentModel.DataAnnotations;

namespace Book_Management_Application.Validations
{

	public class PhoneValidation : ValidationAttribute
	{
		protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
		{
			if (value == null)
			{
				return new ValidationResult("Please enter phone number");
			}
			var phoneNumber = value.ToString();
			if (phoneNumber.Length == 10)
			{
				if (phoneNumber.StartsWith("0"))
				{
					return new ValidationResult("Phone number must start with a valid digit e.g not 0");
				}

				for (int i = 0; i < phoneNumber.Length; i++)
				{

					if (!char.IsDigit(phoneNumber[i]))
					{
						return new ValidationResult("Phone number must contain digits only");
					}

				}
				return ValidationResult.Success;
			}


			else
			{
				return new ValidationResult("Phone number length must be 10 digits long");
			}

		}
	}
}

