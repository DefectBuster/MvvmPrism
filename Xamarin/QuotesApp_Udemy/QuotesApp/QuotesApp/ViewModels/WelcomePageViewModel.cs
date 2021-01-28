using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QuotesApp.ViewModels
{
    public class WelcomePageViewModel : BindableBase
    {
        public DelegateCommand LoginCommand { get; set; }
        public INavigationService NavigationService { get; set; }

        private string welcomeMessage;

        public string WelcomeMessage
        {
            get { return welcomeMessage; }
            set { welcomeMessage = value; }
        }

        public WelcomePageViewModel(INavigationService service)
        {
            NavigationService = service;
            LoginCommand = new DelegateCommand(()=>
            {
                var navigationParameter = new NavigationParameters();
                navigationParameter.Add("paramater", welcomeMessage);
                NavigationService.NavigateAsync("HomePage", navigationParameter);
            });
        }
    }
}
