using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace DigitalPaws.Models
{
	public class Pet
	{
		[Key]
		public int Id { get; set; }
		public string Name { get; set; }
		public string Category { get; set; } // Dog, Cat, etc.
		public string? MedicalConditions { get; set; }
		[ValidateNever]
		public string? QRCodeUrl { get; set; }
		[ValidateNever]
		public string? DisplayPictureUrl { get; set; } // URL for the pet's display picture
		public int? OwnerId { get; set; }
		public User? Owner { get; set; }
	}
}
