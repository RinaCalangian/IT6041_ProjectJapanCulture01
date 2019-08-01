using ProjectJapanCulture.Models;
using ProjectJapanCulture.Data;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjectJapanCulture.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginAdminPage : ContentPage
	{
		public LoginAdminPage ()
		{
			InitializeComponent ();
		}

        async void OnLoginButtonClicked(object sender, EventArgs e)
        {
            var user = new User
            {
                Username = usernameEntry.Text,
                Password = passwordEntry.Text
            };

            var isValid = AreCredentialsCorrect(user);
            if (isValid)
            {
                App.IsUserLoggedIn = true;
                Navigation.InsertPageBefore(new AdministratorPage(), this);
                await Navigation.PopAsync();
            }
            else
            {
                messageLabel.Text = "Login failed";
                passwordEntry.Text = string.Empty;
            }
        }

        bool AreCredentialsCorrect(User user)
        {
            return user.Username == Constants.UsernameAdmin && user.Password == Constants.PasswordAdmin;
        }
    }
}