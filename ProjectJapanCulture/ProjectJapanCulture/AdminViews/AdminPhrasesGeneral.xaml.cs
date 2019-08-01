using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjectJapanCulture.AdminViews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AdminPhrasesGeneral : ContentPage
    {
        public AdminPhrasesGeneral()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            // Reset the 'resume' id, since we just want to re-start here
            ((App)App.Current).ResumeAtProjectJapanCultureId = -1;
            listViewPhGeneral.ItemsSource = await App.Database.GetItemsAsync5();
        }

        async void OnItemAdded(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddPhraseGeneral
            {
                BindingContext = new Models.PhrasesGeneral()
            });
        }

        async void OnListItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                await Navigation.PushAsync(new DetailsPhraseGeneral
                {
                    BindingContext = e.SelectedItem as Models.PhrasesGeneral
                });
            }
        }
    }
}