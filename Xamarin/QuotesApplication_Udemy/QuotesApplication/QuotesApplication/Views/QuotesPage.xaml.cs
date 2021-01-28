
using CommonServiceLocator;
using QuotesApplication.Services;
using QuotesApplication.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace QuotesApplication.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class QuotesPage : ContentPage
    {
        public QuotesPage()
        {
            InitializeComponent();
            BindingContext = ServiceLocator.Current.GetInstance(typeof(QuotesViewModel));
        }
    }
}