﻿using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjectJapanCulture.AdminViews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AddPhraseFood : ContentPage
	{
		public AddPhraseFood ()
		{
			InitializeComponent ();
		}

        // action to save new food phrase
        async void OnSaveClicked(object sender, EventArgs e)
        {
            var foodItem = (Models.PhrasesFood)BindingContext;
            await App.Database.SaveItemAsync4(foodItem);
            await Navigation.PopAsync();
        }

        // action to cancel addition of new food phrase
        async void OnCancelClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}