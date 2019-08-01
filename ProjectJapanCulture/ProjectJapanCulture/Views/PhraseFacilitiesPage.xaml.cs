using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjectJapanCulture.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PhraseFacilitiesPage : ContentPage
	{
		public PhraseFacilitiesPage ()
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

    }
}