using System;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjectJapanCulture.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PhrasesPage : ContentPage
	{
		public PhrasesPage ()
		{
			InitializeComponent ();
            NavigateCommand = new Command<Type>(
                async (Type pageType) =>
                {
                    Page page = (Page)Activator.CreateInstance(pageType);
                    await Navigation.PushAsync(page);
                });
            BindingContext = this;
        }

        public ICommand NavigateCommand { private set; get; }


        // each button when clicked on opens up the page that displays the 
        // list of common phrases the User intends to see

        async void AccomodationButton_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new PhraseAccomodationPage());
        }

        async void ExpressionButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PhraseExpressionPage());
        }

        async void FacilitiesButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PhraseFacilitiesPage());
        }

        async void FoodButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PhraseFoodPage());
        }

        async void GeneralButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PhraseGeneralPage());
        }

        async void TimeButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PhraseTimePage());
        }
    }
}