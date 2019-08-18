using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjectJapanCulture.AdminViews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DetailsPhraseTime : ContentPage
	{
		public DetailsPhraseTime ()
		{
			InitializeComponent ();
		}

        // action to save the changes made
        async void OnSaveClicked(object sender, EventArgs e)
        {
            var timeItem = (Models.PhrasesTime)BindingContext;
            await App.Database.SaveItemAsync6(timeItem);
            await Navigation.PopAsync();
        }

        // action to delete the phrase
        async void OnDeleteClicked(object sender, EventArgs e)
        {
            var timeItem = (Models.PhrasesTime)BindingContext;
            await App.Database.DeleteItemAsync6(timeItem);
            await Navigation.PopAsync();
        }
    }
}