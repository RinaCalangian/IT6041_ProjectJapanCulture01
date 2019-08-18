using ProjectJapanCulture.AdminViews;
using Xamarin.Forms;

namespace ProjectJapanCulture.Views
{
	
	public partial class LocationsPage : ContentPage
	{
		public LocationsPage ()
		{
			InitializeComponent ();
		}

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            // Reset the 'resume' id, since we just want to re-start here
            ((App)App.Current).ResumeAtProjectJapanCultureId = -1;
            listViewLocations.ItemsSource = await App.Database.GetItemsAsync7();
        }

        // action to open LocationsDetailPage (which displays full detail of the selected location)
        async void OnListItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                await Navigation.PushAsync(new LocationDetailPage
                {
                    BindingContext = e.SelectedItem as Models.Locations
                });
            }
        }
    }
}