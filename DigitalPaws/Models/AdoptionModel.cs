namespace DigitalPaws.Models
{
	public class AdoptionModel
	{
		public int Id { get; set; }
		public string? Name { get; set; }
		public string? Breed { get; set; }
		public bool IsAvailable { get; set; }

		public string? Owner { get; set; }

		public string? Contact { get; set; }

		public string? Price { get; set; }

		public string? ImageUrl { get; set; }
	}
}
