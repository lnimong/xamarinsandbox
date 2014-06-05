using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android02.Tool;
using App.Common.ModelMVC;

namespace Android02.Custom
{
	public class CarsAdapter : ArrayAdapter<CarModelMVC>
	{
		public CarsAdapter(Context ctx,  IEnumerable<CarModelMVC> cars) : 
		base (ctx, Resource.Layout.CarPreview, cars.ToArray()) 
		{
		}

		public override View GetView (int position, View itemView, ViewGroup parent)
		{
			var car = GetItem (position);

			if (itemView == null) {
				itemView = LayoutInflater
					.From (Context)
					.Inflate (Resource.Layout.CarPreview, parent, false);
			}

			// Lookup view for data population
			var name = (TextView) itemView.FindViewById(Resource.Id.car_name);
			var dist = (TextView) itemView.FindViewById(Resource.Id.car_dist);
			var year = (TextView) itemView.FindViewById(Resource.Id.car_year);
			var fuel = (TextView) itemView.FindViewById(Resource.Id.car_fuel);

			// Populate the data into the template view using the data object
			name.Text = car.BrandName;
			dist.Text = car.Distance + "km";
			year.Text = car.Year.ToString();
			fuel.Text = car.Fuel;

			// Return the completed view to render on screen
			return itemView;
		}
	}
}

