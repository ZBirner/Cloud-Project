using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace iTunesSearch.Models
{
    public class UserSearches
    {
        public string ipAddress { get; set; }
        public string date { get; set; }
        public string time { get; set; }
        public string searchQuery { get; set; }
        public bool visisted { get; set;  }
    }
}
