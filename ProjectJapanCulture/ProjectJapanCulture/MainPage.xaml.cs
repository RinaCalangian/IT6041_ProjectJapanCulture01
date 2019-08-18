using ProjectJapanCulture.Models;
using System;
using Xamarin.Forms;


// Sets the MainPage of the app to be of type MasterDetailPage
namespace ProjectJapanCulture
{
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();

            masterPage.listView.ItemSelected += OnItemSelected;

            if (Device.RuntimePlatform == Device.UWP)
            {
                MasterBehavior = MasterBehavior.Popover;
            }
        }

        // It defines the object SelectedItem as of type MasterPageItem
        // The action here retrieves the SelectedItem from the ListView instance in MasterPage.xaml
        void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as MasterPageItem;
            if (item != null)
            {
                Detail = new NavigationPage((Page)Activator.CreateInstance(item.TargetType));
                masterPage.listView.SelectedItem = null;
                IsPresented = false;
            }
        }

    }
}
