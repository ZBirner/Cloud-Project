using System.Diagnostics;
using System.Threading.Tasks;
using iTunesSearch.Models;
using System.Net.Http;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Mvc;

namespace iTunesSearch.Controllers
{
    public class HomeController : Controller
    {
        private static readonly HttpClient client = new HttpClient();
        private iTunesSearchModel SearchModel;

        // GET: /<controller>/
        public async Task<IActionResult> Index(string SearchString, string EntityString, string ReturnLimit)
        {
            string SearchQuery = "https://itunes.apple.com/search?term=" + SearchString 
                                                                         + "&entity=" 
                                                                         + EntityString 
                                                                         + "&limit=" 
                                                                         + ReturnLimit;

            string responseString = await client.GetStringAsync(SearchQuery);
            getIP(SearchQuery);

            SearchModel = JsonConvert.DeserializeObject<iTunesSearchModel>(responseString);

            return View(SearchModel);
        }

        // Fills UserSearches object
        private void getIP(string userSearch)
        {
            UserSearches us = new UserSearches();
            var remoteIpAddress = Request.HttpContext.Connection.RemoteIpAddress;
            us.ipAddress = remoteIpAddress.ToString();
            us.searchQuery = userSearch;
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
