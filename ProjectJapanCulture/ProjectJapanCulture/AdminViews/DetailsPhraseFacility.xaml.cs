using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjectJapanCulture.AdminViews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DetailsPhraseFacility : ContentPage
	{
		public DetailsPhraseFacility ()
		{
			InitializeComponent ();
		}

        async void OnSaveClicked(object sender, EventArgs e)
        {
            var facilityItem = (Models.PhrasesFacilities)BindingContext;
            await App.Database.SaveItemAsync4(facilityItem);
            await Navigation.PopAsync();
        }

        async void OnDeleteClicked(object sender, EventArgs e)
        {
            var facilityItem = (Models.PhrasesFacilities)BindingContext;
            await App.Database.DeleteItemAsync3(facilityItem);
            await Navigation.PopAsync();
        }
    }
}