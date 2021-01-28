using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using QuotesApp.Interfaces;
using QuotesApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace QuotesApp.ViewModels
{
    public class QuotesPageViewModel : BindableBase
    {
        public ObservableCollection<Quote> Quotes { get; set; }
        private IQuote quoteInstance;
        public INavigationService NavigationService { get; set; }

        private Quote selectedQuote;

        public Quote SelectedQuote
        {
            get { return selectedQuote; }
            set
            {
                selectedQuote = value;
                if (selectedQuote != null)
                {
                    var navigationParameters = new NavigationParameters();
                    navigationParameters.Add("quotesdetail", selectedQuote);
                    NavigationService.NavigateAsync("QuotesDetail", navigationParameters);
                }
            }
        }

        public QuotesPageViewModel(IQuote quoteObject, INavigationService navigationService)
        {
            Quotes = new ObservableCollection<Quote>();
            quoteInstance = quoteObject;
            LoadQuotes();
            NavigationService = navigationService;
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
