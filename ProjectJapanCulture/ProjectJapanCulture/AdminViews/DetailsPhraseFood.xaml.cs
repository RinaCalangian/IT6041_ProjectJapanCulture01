using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjectJapanCulture.AdminViews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DetailsPhraseFood : ContentPage
	{
		public DetailsPhraseFood ()
		{
			InitializeComponent ();
		}

        async void OnSaveClicked(object sender, EventArgs e)
        {
            var foodItem = (Models.PhrasesFood)BindingContext;
            await App.Database.SaveItemAsync4(foodItem);
            await Navigation.PopAsync();
        }

        async void OnDeleteClicked(object sender, EventArgs e)
        {
            var foodItem = (Models.PhrasesFood)BindingContext;
            await App.Database.DeleteItemAsync4(foodItem);
            await Navigation.PopAsync();
        }
    }
}