using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjectJapanCulture.AdminViews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AdminPhrasesExpression : ContentPage
	{
		public AdminPhrasesExpression ()
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

        async void OnItemAdded(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddPhraseExpression
            {
                BindingContext = new Models.PhrasesExpressions()
            });
        }

        async void OnListItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                await Navigation.PushAsync(new DetailsPhraseExpression
                {
                    BindingContext = e.SelectedItem as Models.PhrasesExpressions
                });
            }

        }
    }
}