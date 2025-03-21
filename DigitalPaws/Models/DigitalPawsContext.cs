using Microsoft.EntityFrameworkCore;

namespace DigitalPaws.Models
{
	public class DigitalPawsContext : DbContext
	{
		public DigitalPawsContext(DbContextOptions<DigitalPawsContext> options) : base(options) { }

		public DbSet<User> Users { get; set; }
		public DbSet<Pet> Pets { get; set; }

		public DbSet<AdoptionModel> AdoptionModels { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<AdoptionModel>().HasData(
               new AdoptionModel
               {
                   Id = 1,
                   Name = "Jack",
                   Breed = "Golden Retriever",
                   IsAvailable = true,
                   Owner = "John Doe",
                   Contact= "5234567890",
                   Price = "$500",
                   ImageUrl = "/images/dog3.jpg"
               },
                new AdoptionModel
                {
                    Id = 2,
                    Name = "Jhonny",
                    Breed = "Labrador",
                    IsAvailable = true,
                    Owner = "Jane Doe",
                    Contact = "4234567891",
                    Price = "$600",
                    ImageUrl = "/images/Lab.jpg"
                },
                new AdoptionModel
                {
                    Id = 3,
                    Name = "Smarty",
                    Breed = "Husky",
                    IsAvailable = true,
                    Owner = "Rony",
                    Contact = "7234567893",
                    Price = "$700",
                    ImageUrl = "/images/dog4.jpg"
                },
                new AdoptionModel
                {
                    Id = 4,
                    Name = "Jerry",
                    Breed = "German Shepherd",
                    IsAvailable = true,
                    Owner = "Andrew",
                    Contact = "8234567894",
                    Price = "$800",
                    ImageUrl = "/images/German.jpg"
                },
                new AdoptionModel
                {
                    Id = 5,
                    Name = "Smurf",
                    Breed = "French Bulldog",
                    IsAvailable = true,
                    Owner = "Samson",
                    Contact = "2234567594",
                    Price = "$900",
                    ImageUrl = "/images/bully.jpeg"
                },
                new AdoptionModel
                {
                    Id = 6,
                    Name = "fiend",
                    Breed = "Rottweiler",
                    IsAvailable = true,
                    Owner = "Chris",
                    Contact = "6234563890",
                    Price = "$1000",
                    ImageUrl = "/images/Roty.jpg"
                },
                new AdoptionModel
                {
                    Id = 7,
                    Name = "Spencer",
                    Breed = "Pomeranian",
                    IsAvailable = false,
                    Owner = "David",
                    Contact = "9234567820",
                    Price = "$700",
                    ImageUrl = "images/Pom.jpg"

                },
                new AdoptionModel
                {
                    Id = 8,
                    Name = "Nox",
                    Breed = "Doberman Pincher",
                    IsAvailable = false,
                    Owner = "Derek",
                    Contact = "2234565666",
                    Price = "$800",
                    ImageUrl = "/images/Doby.jpg"
                },
                new AdoptionModel
                {
                    Id = 9,
                    Name = "Bear",
                    Breed = "Boxer",
                    IsAvailable = false,
                    Owner = "Dylan",
                    Contact = "3234567446",
                    Price = "$900",
                    ImageUrl = "/images/boxer.jpg"
                },
                new AdoptionModel
                {
                    Id = 10,
                    Name = "Timmy",
                    Breed = "Shiba Inu",
                    IsAvailable = false,
                    Owner = "Dexter",
                    Contact= "6126457690",
                    Price = "$1000",
                    ImageUrl = "/images/Shiba.jpg"
                }

            );
        }
    }
}
