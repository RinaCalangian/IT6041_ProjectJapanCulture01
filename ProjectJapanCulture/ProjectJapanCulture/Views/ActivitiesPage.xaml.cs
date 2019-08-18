using Xamarin.Forms;

namespace ProjectJapanCulture.Views
{
	public partial class ActivitiesPage : ContentPage
	{
		public ActivitiesPage ()
		{
			InitializeComponent ();
		}

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            // Reset the 'resume' id, since we just want to re-start here
            ((App)App.Current).ResumeAtProjectJapanCultureId = -1;
            listViewActivities.ItemsSource = await App.Database.GetItemsAsync8();
        }

        // action to open ActivityDetailPage (which displays full detail of the selected activity)
        async void OnListItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                await Navigation.PushAsync(new ActivityDetailPage
                {
                    BindingContext = e.SelectedItem as Models.Activities
                });
            }
        }
    }
}