using System;
using UIKit;
using Xamarin.Forms;
using XamarinPLCDemo.iOS;
using Foundation;
using System.Diagnostics;

[assembly: Dependency(typeof(PhoneDialer))]

namespace XamarinPLCDemo.iOS
{
	public class PhoneDialer : IDialer
	{
		public bool Dial(String number){
//			Debug.WriteLine ("huahroan");
//			Console.WriteLine ("woqua");
			return UIApplication.SharedApplication.OpenUrl (
				new NSUrl ("tel:" + number));
		}
	}
}

