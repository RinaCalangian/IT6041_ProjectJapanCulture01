
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjectJapanCulture.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PhraseFoodPage : ContentPage
	{
		public PhraseFoodPage ()
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

    }
}