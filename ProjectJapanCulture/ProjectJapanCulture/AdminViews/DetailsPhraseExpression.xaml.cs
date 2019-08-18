using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjectJapanCulture.AdminViews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DetailsPhraseExpression : ContentPage
	{
		public DetailsPhraseExpression ()
		{
			InitializeComponent ();
		}

        // action to save the changes made
        async void OnSaveClicked(object sender, EventArgs e)
        {
            var expressionItem = (Models.PhrasesExpressions)BindingContext;
            await App.Database.SaveItemAsync2(expressionItem);
            await Navigation.PopAsync();
        }

        // action to delete the phrase
        async void OnDeleteClicked(object sender, EventArgs e)
        {
            var expressionItem = (Models.PhrasesExpressions)BindingContext;
            await App.Database.DeleteItemAsync2(expressionItem);
            await Navigation.PopAsync();

        }
    }
}