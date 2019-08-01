using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjectJapanCulture.AdminViews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DetailsPhraseGeneral : ContentPage
	{
		public DetailsPhraseGeneral ()
		{
			InitializeComponent ();
		}

        async void OnSaveClicked(object sender, EventArgs e)
        {
            var generalItem = (Models.PhrasesGeneral)BindingContext;
            await App.Database.SaveItemAsync5(generalItem);
            await Navigation.PopAsync();
        }

        async void OnDeleteClicked(object sender, EventArgs e)
        {
            var generalItem = (Models.PhrasesGeneral)BindingContext;
            await App.Database.DeleteItemAsync5(generalItem);
            await Navigation.PopAsync();
        }
    }
}