namespace Cascading.Models
{
    public class CountryStateCityViewModel
    {
        public IEnumerable<Country> Countries { get; set; }
        public int SelectedCountryId { get; set; }
        public IEnumerable<State> States { get; set; }
        public int SelectedStateId { get; set; }
        public IEnumerable<City> Cities { get; set; }
        public int CityId { get; set; }
    }


}
