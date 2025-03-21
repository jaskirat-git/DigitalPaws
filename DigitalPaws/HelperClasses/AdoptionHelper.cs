using DigitalPaws.Models;
using DigitalPaws.Models.ViewModels;
using System;
using System.Collections.Generic;
using DigitalPaws.HelperClasses;

namespace DigitalPaws.HelperClasses
{
    public class AdoptionHelper
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public string? Breed { get; set; }

        public string? Owner { get; set; }

        public string? Contact { get; set; }

        public string? Price { get; set; }

        //public string? Author { get; set; }

        //public string? GenreId { get; set; }

        //public string? GenreName { get; set; }

        //public int? Year { get; set; }

        public bool IsAvailable { get; set; }

        //public Genre? Genre { get; set; }

        private DigitalPawsContext Context;

        public AdoptionHelper(DigitalPawsContext context)
        {
            Context = context;
        }

        public List<AdoptionModel> GetBooks()
        {
            //return Context.AdoptionModels.ToList();
            return new List<AdoptionModel>
            {
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
            };
        }

        public List<AdoptionModel> SearchBooks(String searchTerm)
        {
            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                //return Context.AdoptionModels.ToList();
                return new List<AdoptionModel>
            {
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
            };
            }

            searchTerm = searchTerm.ToLower();

            return Context.AdoptionModels.Where(b => b.Name.ToLower().Contains(searchTerm)
                || b.Breed.ToLower().Contains(searchTerm)).ToList();
        }

        //public List<AdoptionModel> FilterByGenre(List<AdoptionModel> products, string genre)
        //{
        //    if (string.IsNullOrWhiteSpace(genre))
        //    {
        //        //return Context.Books.ToList();
        //        return products;
        //    }
        //    return Context.AdoptionModels.Where(b => b.Genre.GenreName.ToLower() == genre.ToLower()).ToList();
        //}


        public List<AdoptionModel> FilterByAvailable(List<AdoptionModel> products, bool? isAvailable)
        {
            if (isAvailable == null)
            {
                return products;
            }
            return products.Where(b => b.IsAvailable == isAvailable.Value).ToList();

        }

        public List<AdoptionModel> SortBooks(List<AdoptionModel> books, string sortBy)
        {
            switch (sortBy)
            {
                case "name":
                    return books.OrderBy(b => b.Name).ToList();
                case "breed":
                    return books.OrderBy(b => b.Breed).ToList();
                //case "Year":
                //    return books.OrderBy(b => b.Year).ToList();
                default:
                    return books.OrderBy(b => b.Name).ToList();

            }


        }
        //public List<String> GetGenres()
        //{
        //    return Context.Genres.Select(b => b.GenreName).ToList();
        //}

    }
}
