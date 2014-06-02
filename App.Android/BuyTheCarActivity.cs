using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using App.Common.ModelMVC;

namespace Android02
{
	[Activity (Label = "BuyTheCarActivity")]			
	public class BuyTheCarActivity : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Create your application here
			SetContentView (Resource.Layout.Buy);

			var intent = Intent;

			var carid = intent.GetStringExtra ("param");

			var car = new BuyModelMVC (carid, new PhoneService(this));

			var text = FindViewById <TextView> (Resource.Id.expl);
			var phone = FindViewById<EditText> (Resource.Id.phone);

			text.Text = car.Explain;
			phone.Text = car.Phone;
		}
	}
}

