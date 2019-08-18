using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjectJapanCulture.AdminViews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AddPhraseFacility : ContentPage
	{
		public AddPhraseFacility ()
		{
			InitializeComponent ();
		}

        // action to save new facility phrase
        async void OnSaveClicked(object sender, EventArgs e)
        {
            var facilityItem = (Models.PhrasesFacilities)BindingContext;
            await App.Database.SaveItemAsync4(facilityItem);
            await Navigation.PopAsync();
        }

        // action to cancel addition of new facility phrase
        async void OnCancelClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}