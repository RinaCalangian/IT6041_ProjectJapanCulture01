﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ProjectJapanCulture.Data;
using System.IO;

// it contains a constructor that calls the InitializeComponent method 
// and its main purpose is to initialize the elements declared in the XAML file
// App.xaml.cs also contains methods to handle activation and suspension of the app

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace ProjectJapanCulture
{
    public partial class App : Application
    {
        public static bool IsUserLoggedIn { get; set; }
        static ProjectDatabase database;

        public App()
        {
            InitializeComponent();
            MainPage = new ProjectJapanCulture.MainPage();
        }

        public static ProjectDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new ProjectDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), 
                        " Activities.db3"));
                }
                return database;
            }
        }

        public int ResumeAtProjectJapanCultureId { get; set; }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
