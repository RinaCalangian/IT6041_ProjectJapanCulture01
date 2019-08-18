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
	public partial class AdminActivities : ContentPage
	{
		public AdminActivities ()
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

        // action to open AddActivity page
        async void OnItemAdded(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddActivity
            {
                BindingContext = new Models.Activities()
            });
        }

        // action to open DetailsActivity page
        async void OnListItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                await Navigation.PushAsync(new DetailsActivity
                {
                    BindingContext = e.SelectedItem as Models.Activities
                });
            }
        }
    }
}