using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using QuotesApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QuotesApp.ViewModels
{
    public class QuotesDetailViewModel : BindableBase, INavigationAware
    {
        private Quote quote;
        private string quoteDescription;

        public string QuoteDescription
        {
            get { return quoteDescription; }
            set { SetProperty(ref quoteDescription, value); }
        }

        public QuotesDetailViewModel()
        {

        }

        public void OnNavigatedFrom(INavigationParameters parameters)
        {
        }

        public void OnNavigatedTo(INavigationParameters parameters)
        {
            quote = (Quote)parameters["quotesdetail"];
            QuoteDescription = quote.Description;
        }
    }
}
