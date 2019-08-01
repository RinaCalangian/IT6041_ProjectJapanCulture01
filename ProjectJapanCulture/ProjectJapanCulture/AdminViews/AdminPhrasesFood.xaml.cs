using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjectJapanCulture.AdminViews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AdminPhrasesFood : ContentPage
	{
		public AdminPhrasesFood ()
		{
			InitializeComponent ();
		}

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            // Reset the 'resume' id, since we just want to re-start here
            ((App)App.Current).ResumeAtProjectJapanCultureId = -1;
            listViewPhFood.ItemsSource = await App.Database.GetItemsAsync4();
        }


        async void OnItemAdded(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddPhraseFood
            {
                BindingContext = new Models.PhrasesFood()
            });
        }

        async void OnListItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                await Navigation.PushAsync(new DetailsPhraseFood
                {
                    BindingContext = e.SelectedItem as Models.PhrasesFood
                });
            }
        }
    }
}