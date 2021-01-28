using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Net.Http;
using Newtonsoft.Json;
using QuotesApplication.Models;
using System.Collections.ObjectModel;
using QuotesApplication.Services;
using QuotesApplication.Interfaces;

namespace QuotesApplication.ViewModels
{
    public class QuotesViewModel : BaseViewModel
    {
        public ObservableCollection<Quote> Quotes { get; set; }
        private IQuotes quoteInstance;
        public QuotesViewModel(IQuotes quoteObject)
        {
            Quotes = new ObservableCollection<Quote>();
            quoteInstance = quoteObject;
            LoadQuotes();
        }

        private async void LoadQuotes()
        {
            var quotes = await quoteInstance.GetQuotes();

            //LvQuotes.ItemsSource = quotes;
            foreach (var quote in quotes)
            {
                Quotes.Add(quote);
            }
        }
    }
}
