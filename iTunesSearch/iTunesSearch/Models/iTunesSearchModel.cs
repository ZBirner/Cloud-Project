namespace iTunesSearch.Models
{
    public class iTunesSearchModel
    {
        public int resultCount { get; set; }
        public Results[] results = new Results[200];
    }

}
