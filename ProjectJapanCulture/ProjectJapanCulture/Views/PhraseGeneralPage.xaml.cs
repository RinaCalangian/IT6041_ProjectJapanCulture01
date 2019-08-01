
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjectJapanCulture.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PhraseGeneralPage : ContentPage
	{
		public PhraseGeneralPage ()
		{
			InitializeComponent ();
		}

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            // Reset the 'resume' id, since we just want to re-start here
            ((App)App.Current).ResumeAtProjectJapanCultureId = -1;
            listViewPhGeneral.ItemsSource = await App.Database.GetItemsAsync5();
        }

    }
}