using QuotesApplication.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace QuotesApplication.Interfaces
{
    public interface IQuotes
    {
        Task<List<Quote>> GetQuotes();
    }
}
