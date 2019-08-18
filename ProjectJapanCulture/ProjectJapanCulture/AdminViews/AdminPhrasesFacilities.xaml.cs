using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjectJapanCulture.AdminViews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AdminPhrasesFacilities : ContentPage
	{
		public AdminPhrasesFacilities ()
		{
			InitializeComponent ();
		}

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            // Reset the 'resume' id, since we just want to re-start here
            ((App)App.Current).ResumeAtProjectJapanCultureId = -1;
            listViewPhFacility.ItemsSource = await App.Database.GetItemsAsync3();
        }

        // action to open class AddPhraseFacility page
        async void OnItemAdded(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddPhraseFacility
            {
                BindingContext = new Models.PhrasesFacilities()
            });
        }

        // action to open DetailsPhraseFacility page
        async void OnListItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                await Navigation.PushAsync(new DetailsPhraseFacility
                {
                    BindingContext = e.SelectedItem as Models.PhrasesFacilities
                });
            }

        }
    }
}