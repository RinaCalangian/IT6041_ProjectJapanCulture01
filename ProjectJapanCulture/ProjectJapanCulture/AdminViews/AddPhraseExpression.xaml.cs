using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjectJapanCulture.AdminViews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AddPhraseExpression : ContentPage
	{
		public AddPhraseExpression ()
		{
			InitializeComponent ();
		}

        async void OnSaveClicked(object sender, EventArgs e)
        {
            var expressionItem = (Models.PhrasesExpressions)BindingContext;
            await App.Database.SaveItemAsync2(expressionItem);
            await Navigation.PopAsync();
        }

        async void OnCancelClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}