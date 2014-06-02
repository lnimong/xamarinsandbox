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
using Android02.Tool;

namespace Android02
{		
	public class CarListActivity : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Create your application here
			SetContentView (Resource.Layout.CarList);

			var vm = new CarListModelMVC ();
			var list = (ListView)FindViewById (Resource.Id.mainList);

			var adapter = new Custom.CarsAdapter (this, vm.Cars);

			list.Adapter = adapter;

			var array = vm.Cars.ToArray ();
			list.ItemClick += (object sender, AdapterView.ItemClickEventArgs e) => {
				var item = array[e.Position];
				this.NavigateTo(item.BuyPage);
			};

		}
	}
}

