﻿using Xamarin.Forms;
using Android.Content;
using Android.Telephony;
using System.Linq;
using XamarinPLCDemo.Droid;

using Uri = Android.Net.Uri;

[assembly: Dependency(typeof(PhoneDialer))]
namespace XamarinPLCDemo.Droid
{
	public class PhoneDialer : IDialer
	{
		public bool Dial(string number)
		{
			var context = Forms.Context;
			if (context == null)
				return false;

			var intent = new Intent (Intent.ActionCall);
			intent.SetData (Uri.Parse ("tel:" + number));

			if (IsIntentAvailable (context, intent)) {
				context.StartActivity (intent);
				return true;
			}

			return false;
		}

		public static bool IsIntentAvailable(Context context, Intent intent)
		{
			var packageManager = context.PackageManager;

			var list = packageManager.QueryIntentServices (intent, 0)
				.Union (packageManager.QueryIntentActivities (intent, 0));

			if (list.Any ())
				return true;

			var manager = TelephonyManager.FromContext (context);
			return manager.PhoneType != PhoneType.None;
		}
	}
}

