namespace DigitalPaws.Models.ViewModels
{
    public class SearchViewModel
    {
        public List<AdoptionModel> AdoptionModels { get; set; }
        //public List<Member> Members { get; set; }

        //public List<string> Genres { get; set; }

        public string? SearchTerm { get; set; }

        //public string? SelectedGenre { get; set; }

        public string? SortBy { get; set; }

        public string? IsAvailable { get; set; }
        //public string? HasIssuedBook { get; set; }
    }
}
