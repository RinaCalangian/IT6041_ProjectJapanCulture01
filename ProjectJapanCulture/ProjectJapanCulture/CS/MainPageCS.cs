using ProjectJapanCulture.CS;
using ProjectJapanCulture.Models;
using System;
using Xamarin.Forms;

// MainPageCS is set to be of type MasterDetailPage
// This is the page that declares the object masterPage to be of type MasterPageCS 
// Object masterPage will be called or referenced in MainPage.xaml

namespace ProjectJapanCulture
{
    public class MainPageCS : MasterDetailPage
    {
        MasterPageCS masterPage;

        public MainPageCS()
        {
            masterPage = new MasterPageCS();
            Master = masterPage;
            //Detail = new NavigationPage(new ContactsPageCS());

            masterPage.ListView.ItemSelected += OnItemSelected;

            if (Device.RuntimePlatform == Device.UWP)
            {
                MasterBehavior = MasterBehavior.Popover;
            }
        }

        // the action that opens up a page of type NavigationPage corresponding to the item selected in the Navigation Bar menu
        void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as MasterPageItem;
            if (item != null)
            {
                Detail = new NavigationPage((Page)Activator.CreateInstance(item.TargetType));
                masterPage.ListView.SelectedItem = null;
                IsPresented = false;
            }
        }
    }

}
