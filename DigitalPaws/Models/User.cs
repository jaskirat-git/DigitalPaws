
using System.ComponentModel.DataAnnotations;

namespace DigitalPaws.Models
{
	public class User
	{
		public int Id { get; set; }

		[Required(ErrorMessage = "Username is required.")]
		[StringLength(50, ErrorMessage = "Username cannot exceed 50 characters.")]
		public string Username { get; set; }

		[Required(ErrorMessage = "Password is required.")]
		[DataType(DataType.Password)]
		[StringLength(100, ErrorMessage = "Password cannot exceed 100 characters.")]
		public string Password { get; set; }

		[Required(ErrorMessage = "Name is required.")]
		[StringLength(100, ErrorMessage = "Name cannot exceed 100 characters.")]
		public string Name { get; set; }

		[Required(ErrorMessage = "Email is required.")]
		[DataType(DataType.EmailAddress)]
		[StringLength(100, ErrorMessage = "Email cannot exceed 100 characters.")]
		public string Email { get; set; }

		[Required(ErrorMessage = "Mobile number is required.")]
		[RegularExpression(@"^\+?[1-9]\d{1,14}$", ErrorMessage = "Invalid mobile number format.")]
		public string MobileNumber { get; set; } // New field

		[Required(ErrorMessage = "Address is required.")]
		[StringLength(200, ErrorMessage = "Address cannot exceed 200 characters.")]
		public string Address { get; set; } // New field

		public string Role { get; set; } = "User";
	}
}
