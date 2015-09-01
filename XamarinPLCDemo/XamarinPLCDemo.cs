using System;

using Xamarin.Forms;
using System.Collections.Generic;

namespace XamarinPLCDemo
{
	public class App : Application
	{
		public static List<string> PhoneNumbers { get; set;}
		public App ()
		{
			// The root page of your application
//			MainPage = new ContentPage {
//				Content = new StackLayout {
//					VerticalOptions = LayoutOptions.Center,
//					Children = {
//						new Label {
//							XAlign = TextAlignment.Center,
//							Text = "Welcome to Xamarin Forms!"
//						}
//					}
//				}
//			};
			PhoneNumbers = new List<string> ();
//			MainPage = new XamarinPLCDemo.MainPage ();
			MainPage = new NavigationPage(new XamarinPLCDemo.MainPage());
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}

