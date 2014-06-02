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
	[Activity (Label = "CallActivity")]			
	public class CallActivity : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			var vm = new CallModelMVC ();

			// Create your application here
			var uri = Android.Net.Uri.Parse ("tel:" + vm.PhoneNumber);
			var intent = new Intent (Intent.ActionView, uri); 
			StartActivity (intent);  

		}
	}
}

