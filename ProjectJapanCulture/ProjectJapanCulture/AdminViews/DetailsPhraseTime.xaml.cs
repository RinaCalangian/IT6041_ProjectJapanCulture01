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

        async void OnSaveClicked(object sender, EventArgs e)
        {
            var timeItem = (Models.PhrasesTime)BindingContext;
            await App.Database.SaveItemAsync6(timeItem);
            await Navigation.PopAsync();
        }

        async void OnDeleteClicked(object sender, EventArgs e)
        {
            var timeItem = (Models.PhrasesTime)BindingContext;
            await App.Database.DeleteItemAsync6(timeItem);
            await Navigation.PopAsync();
        }
    }
}