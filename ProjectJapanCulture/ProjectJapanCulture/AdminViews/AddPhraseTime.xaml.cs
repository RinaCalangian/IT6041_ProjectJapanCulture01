using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjectJapanCulture.AdminViews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AddPhraseTime : ContentPage
	{
		public AddPhraseTime ()
		{
			InitializeComponent ();
		}

        // action to save new time phrase
        async void OnSaveClicked(object sender, EventArgs e)
        {
            var timeItem = (Models.PhrasesTime)BindingContext;
            await App.Database.SaveItemAsync6(timeItem);
            await Navigation.PopAsync();
        }

        // action to cancel addition of new time phrase
        async void OnCancelClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}