using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjectJapanCulture.AdminViews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AdminPhrasesAccomodation : ContentPage
	{
		public AdminPhrasesAccomodation ()
		{
			InitializeComponent ();
		}

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            // Reset the 'resume' id, since we just want to re-start here
            ((App)App.Current).ResumeAtProjectJapanCultureId = -1;
            listViewPhAccomodation.ItemsSource = await App.Database.GetItemsAsync();
        }

        // action to open class AddPhraseAccomodation page
        async void OnItemAdded(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddPhraseAccomodation
            {
                BindingContext = new Models.PhrasesAccomodation()
            });
        }

        // action to open DetailsPhraseAccomodation page
        async void OnListItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                await Navigation.PushAsync(new DetailsPhraseAccomodation
                {
                    BindingContext = e.SelectedItem as Models.PhrasesAccomodation
                });
            }
        }
    }
}