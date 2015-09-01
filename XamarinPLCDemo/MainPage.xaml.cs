using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;
using System;
using System.Diagnostics;

namespace XamarinPLCDemo
{
	public partial class MainPage : ContentPage
	{
		string translatedNumber;
		public MainPage ()
		{
			InitializeComponent ();//这个就是家在xaml文件的敌方
		}
		void OnTranslate (object sender, EventArgs e){
			translatedNumber = Core.PhonewordTranslator.ToNumber (phoneNumberText.Text);
			if (!string.IsNullOrWhiteSpace (translatedNumber)) {
				callButton.IsEnabled = true;
				callButton.Text = "Call " + translatedNumber;
			} else {
				callButton.IsEnabled = false;
				callButton.Text = "Call";
			}
		}

		async void OnCall (object sender, EventArgs e){
			if (await this.DisplayAlert (
				    "Dial a Number",
				    "Would you like to call " + translatedNumber + "?",
				    "Yes",
				    "No")) {
				var dialer = DependencyService.Get<IDialer> ();
				if (dialer != null) {
					dialer.Dial (translatedNumber);
					App.PhoneNumbers.Add (translatedNumber);
					callHistoryButton.IsEnabled = true;
				}
					
			}
		}

		void OnCallHistory(object sender, EventArgs e){
			 Navigation.PushModalAsync (new CallHistoryPage ());
		}
	  	private void Slider_ValueChanged(object sender, EventArgs e)
		{
//			Console.WriteLine ("asdf");
//			Debug.WriteLine(((Slider)sender).Value);
		}
	}
}

