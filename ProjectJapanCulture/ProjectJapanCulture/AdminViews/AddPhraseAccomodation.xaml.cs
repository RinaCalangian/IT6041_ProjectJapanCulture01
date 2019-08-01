using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjectJapanCulture.AdminViews
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AddPhraseAccomodation : ContentPage
	{
		public AddPhraseAccomodation ()
		{
			InitializeComponent ();
		}

        async void OnSaveClicked(object sender, EventArgs e)
        {
            var accomodationItem = (Models.PhrasesAccomodation)BindingContext;
            await App.Database.SaveItemAsync(accomodationItem);
            await Navigation.PopAsync();
        }

        async void OnCancelClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}