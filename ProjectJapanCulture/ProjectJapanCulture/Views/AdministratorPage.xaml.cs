using System;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ProjectJapanCulture.AdminViews;
using SQLite;

namespace ProjectJapanCulture.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AdministratorPage : ContentPage
	{
		public AdministratorPage ()
        {
            InitializeComponent();
            NavigateCommand = new Command<Type>(
                async (Type pageType) =>
                {
                    Page page = (Page)Activator.CreateInstance(pageType);
                    await Navigation.PushAsync(page);
                });
            BindingContext = this;
        }

        public ICommand NavigateCommand { private set; get; }

        async void ActivityButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AdminActivities());
        }
        async void LocationButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AdminLocations());
        }

        async void AccomodationButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AdminPhrasesAccomodation());
        }

        async void ExpressionButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AdminPhrasesExpression());
        }

        async void FacilitiesButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AdminPhrasesFacilities());
        }

        async void FoodButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AdminPhrasesFood());
        }

        async void GeneralButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AdminPhrasesGeneral());
        }

        async void TimeButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AdminPhrasesTime());
        }
    }
}