using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjectJapanCulture.AdminViews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AdminLocations : ContentPage
	{
		public AdminLocations ()
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

        async void OnItemAdded(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddLocation
            {
                BindingContext = new Models.Locations()
            });
        }

        async void OnListItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                await Navigation.PushAsync(new DetailsLocation
                {
                    BindingContext = e.SelectedItem as Models.Locations
                });
            }
        }
    }
}