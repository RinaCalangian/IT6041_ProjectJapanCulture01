using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjectJapanCulture.AdminViews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DetailsPhraseAccomodation : ContentPage
	{
		public DetailsPhraseAccomodation ()
		{
			InitializeComponent ();
		}

        async void OnSaveClicked(object sender, EventArgs e)
        {
            var accomodationItem = (Models.PhrasesAccomodation)BindingContext;
            await App.Database.SaveItemAsync(accomodationItem);
            await Navigation.PopAsync();
        }

        async void OnDeleteClicked(object sender, EventArgs e)
        {
            var accomodationItem = (Models.PhrasesAccomodation)BindingContext;
            await App.Database.DeleteItemAsync(accomodationItem);
            await Navigation.PopAsync();
        }
    }
}