using QuotesApp.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace QuotesApp.Interfaces
{
    public interface IQuote
    {
        Task<List<Quote>> GetQuotes();
    }
}
