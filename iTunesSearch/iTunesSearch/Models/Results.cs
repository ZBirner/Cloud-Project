using System;
using System.Collections;

namespace iTunesSearch.Models
{
    public class Results
    {
        public string wrapperType { get; set; }
        public string kind { get; set; }
        public string trackName { get; set; }
        public string artistName { get; set; }
        public string collectionName { get; set; }
        public string artistLinkUrl { get; set; }
        public string collectionViewUrl { get; set; }
        public string trackViewUrl { get; set; }
        public double collectionPrice { get; set; } = -1;
        public double trackPrice { get; set; } = -1;
        public string formattedPrice { get; set; }
    }

}
