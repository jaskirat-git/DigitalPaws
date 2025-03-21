using DigitalPaws.HelperClasses;
using Microsoft.AspNetCore.Mvc;
using DigitalPaws.Models;
using DigitalPaws.Models.ViewModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DigitalPaws.Controllers
{
    public class AdoptionController : Controller
    {
        DigitalPawsContext Context;
        AdoptionHelper Helper;

        public AdoptionController(DigitalPawsContext context)
        {
            Context = context;
            Helper = new AdoptionHelper(Context);
        }
        public IActionResult Index(string searchTerm, string sortby, string availability)
        {
            //var books = Context.Books.Include(m => m.Genre).OrderBy(m => m.Name).ToList();
            //return View(books);

            bool? isAvailable = availability switch
            {
                "available" => true,
                "unavailable" => false,
                _ => null
            };

            var Books = Helper.SearchBooks(searchTerm);

            //Books = Helper.FilterByGenre(Books, genre);
            Books = Helper.FilterByAvailable(Books, isAvailable);

            Books = Helper.SortBooks(Books, sortby);


            var viewModel = new SearchViewModel
            {
                AdoptionModels = Books,
                //Genres = bookHelper.GetGenres(),
                SearchTerm = searchTerm,
                //SelectedGenre = genre,
                SortBy = sortby,
                IsAvailable = availability,
            };
            return View(viewModel);


            //return View();
        }

        public IActionResult Details(int id)
        {
            var pet = Context.AdoptionModels.FirstOrDefault(p => p.Id == id);
            if (pet == null) return NotFound();

            return View(pet);
        }

    }
}
