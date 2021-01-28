using CommonServiceLocator;
using QuotesApplication.Interfaces;
using QuotesApplication.Services;
using QuotesApplication.Views;
using System;
using Unity;
using Unity.ServiceLocation;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace QuotesApplication
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            var unityContainer = new UnityContainer();
            unityContainer.RegisterType<IQuotes, QuotesApi>();
            ServiceLocator.SetLocatorProvider(()=>new UnityServiceLocator(unityContainer));

            MainPage = new QuotesPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
