using Newtonsoft.Json;
using QuotesApplication.Interfaces;
using QuotesApplication.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace QuotesApplication.Services
{
    public class QuotesApi : IQuotes
    {
        public async Task<List<Quote>> GetQuotes()
        {
            var httpclient = new HttpClient();
            var response = await httpclient.GetStringAsync("https://quotessamplerestfulwebapi.azurewebsites.net/api/quotes");
            return JsonConvert.DeserializeObject<List<Quote>>(response);
        }
    }
}
