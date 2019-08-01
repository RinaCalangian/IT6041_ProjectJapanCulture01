using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjectJapanCulture.AdminViews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AdminPhrasesTime : ContentPage
	{
		public AdminPhrasesTime ()
		{
			InitializeComponent ();
		}

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            // Reset the 'resume' id, since we just want to re-start here
            ((App)App.Current).ResumeAtProjectJapanCultureId = -1;
            listViewPhTime.ItemsSource = await App.Database.GetItemsAsync6();
        }


        async void OnItemAdded(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddPhraseTime
            {
                BindingContext = new Models.PhrasesTime()
            });
        }

        async void OnListItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                await Navigation.PushAsync(new DetailsPhraseTime
                {
                    BindingContext = e.SelectedItem as Models.PhrasesTime
                });
            }

        }
    }
}