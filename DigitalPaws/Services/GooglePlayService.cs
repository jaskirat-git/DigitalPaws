namespace DigitalPaws.Services
{
    public class GooglePlacesService
    {
        private readonly HttpClient _httpClient;
        private readonly string _apiKey;

        public GooglePlacesService(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _apiKey = configuration["GooglePlaces:ApiKey"]; 
        }

        public async Task<string> GetNearbyVetsAsync(string location, int radius)
        {
            string url = $"https://maps.googleapis.com/maps/api/place/nearbysearch/json?location={location}&radius={radius}&type=veterinary_care&key={_apiKey}";
            return await _httpClient.GetStringAsync(url);
        }
    }
}



