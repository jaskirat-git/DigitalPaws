namespace DigitalPaws.Models
{
	public class Pet
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Category { get; set; } // Dog, Cat, etc.
		public string MedicalConditions { get; set; }
		public string QRCodeUrl { get; set; }
		public int OwnerId { get; set; }
		public User Owner { get; set; }
	}
}
