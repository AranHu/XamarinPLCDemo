using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamarinPLCDemo
{
	public partial class CallHistoryPage : ContentPage
	{
		public CallHistoryPage ()
		{
			InitializeComponent ();
		}

		//这里写不写private等什么的都好像差不多的啊
		private void OnGoBack(object sender, EventArgs e){
			Navigation.PopModalAsync ();
		}
	}
}

