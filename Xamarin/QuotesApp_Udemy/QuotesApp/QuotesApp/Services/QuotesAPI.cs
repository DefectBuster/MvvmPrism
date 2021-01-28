using Newtonsoft.Json;
using QuotesApp.Interfaces;
using QuotesApp.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace QuotesApp.Services
{
    public class QuotesApi : IQuote
    {
        public async Task<List<Quote>> GetQuotes()
        {
            var httpclient = new HttpClient();
            var response = await httpclient.GetStringAsync("https://quotessamplerestfulwebapi.azurewebsites.net/api/quotes");
            return JsonConvert.DeserializeObject<List<Quote>>(response);
        }
    }
}
