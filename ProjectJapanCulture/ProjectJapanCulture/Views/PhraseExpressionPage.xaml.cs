
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjectJapanCulture.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PhraseExpressionPage : ContentPage
	{
		public PhraseExpressionPage ()
		{
			InitializeComponent ();
		}

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            // Reset the 'resume' id, since we just want to re-start here
            ((App)App.Current).ResumeAtProjectJapanCultureId = -1;
            listViewPhExpression.ItemsSource = await App.Database.GetItemsAsync2();
        }

    }
}