using System;
using System.Linq;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android02.Tool;
using App.Common.ModelMVC;

namespace Android02
{
	[Activity (Label = "Android02", MainLauncher = true)]
	public class MainActivity : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			var vm = new MainMenuModelMVC ();

			SetButton (Resource.Id.cars, vm.Cars);

			SetButton (Resource.Id.about, vm.AboutUs);

			SetButton (Resource.Id.mail, vm.MailUs);

			SetButton (Resource.Id.call, vm.CallUs);

			SetButton (Resource.Id.services, vm.RentService);

		}

		void SetButton (int item, MenuLinkModelMVC vm)
		{
			// Get our button from the layout resource,
			// and attach an event to it
			var button = FindViewById<Button> (item);
			button.Text = vm.Label;
			button.Click += (object sender, EventArgs e) =>  {
				this.NavigateTo(vm.Page);
			};
		}
	}
}


