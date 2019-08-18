using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjectJapanCulture.AdminViews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AddPhraseGeneral : ContentPage
	{
		public AddPhraseGeneral ()
		{
			InitializeComponent ();
		}

        // action to save new general phrase
        async void OnSaveClicked(object sender, EventArgs e)
        {
            var generalItem = (Models.PhrasesGeneral)BindingContext;
            await App.Database.SaveItemAsync5(generalItem);
            await Navigation.PopAsync();

        }

        // action to cancel addition of new general phrase
        async void OnCancelClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}