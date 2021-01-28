using Prism;
using Prism.Ioc;
using QuotesApp.Interfaces;
using QuotesApp.Services;
using QuotesApp.ViewModels;
using QuotesApp.Views;
using Xamarin.Essentials.Implementation;
using Xamarin.Essentials.Interfaces;
using Xamarin.Forms;

namespace QuotesApp
{
    public partial class App
    {
        public App(IPlatformInitializer initializer)
            : base(initializer)
        {
        }

        protected override async void OnInitialized()
        {
            InitializeComponent();

            //await NavigationService.NavigateAsync("NavigationPage/WelcomePage");
            await NavigationService.NavigateAsync("NavigationPage/QuotesPage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IAppInfo, AppInfoImplementation>();

            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<QuotesPage, QuotesPageViewModel>();
            containerRegistry.RegisterSingleton<IQuote, QuotesApi>();
            containerRegistry.RegisterForNavigation<QuotesDetail, QuotesDetailViewModel>();
        }
    }
}
