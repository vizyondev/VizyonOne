﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace VizyonOne
{
    public partial class App : Application
    {
        public App()    // The root page of your application
        {
            //InitializeComponent();
            //var naviationPage = new Views.MainView();
            //MainPage = new Views.LoginView();
            MainPage = new Views.MainView();
        }

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
