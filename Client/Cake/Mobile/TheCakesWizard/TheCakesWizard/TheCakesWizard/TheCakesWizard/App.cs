using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Syncfusion.SfBusyIndicator.XForms;
using Xamarin.Forms;
using TheCakesWizard.Views;

namespace TheCakesWizard
{
    public class App : Application
    {
        public App()
        {
            // The root page of your application
            //var content = new ContentPage
            //{
            //    Title = "The Cakes Wizard",
            //    Content = new StackLayout
            //    {
            //        VerticalOptions = LayoutOptions.Center,
            //        Children = {
            //            new Label {
            //                HorizontalTextAlignment = TextAlignment.Center,
            //                Text = "Welcome to Xamarin Forms!"
            //            }
            //        }
            //    }
            //};

            var content = new Splash();

            //var content = new ContentPage
            //{
            //    Title = "The Cakes Wizard",
            //    Content = new StackLayout
            //    {
            //        VerticalOptions = LayoutOptions.Center,
            //        Children = {
            //            new  SfBusyIndicator()
            //            }
            //    }            
            //};

        MainPage = new NavigationPage(content);
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
