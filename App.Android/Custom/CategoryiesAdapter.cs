using System;
using System.Linq;
using Android.Widget;
using App.Common.ModelMVC;
using System.Collections.Generic;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android02.Tool;

namespace Android02.Custom
{
	public class CategoryiesAdapter : ArrayAdapter<CategoryModelMVC>
	{
		public CategoryiesAdapter(Context ctx,  IEnumerable<CategoryModelMVC> categories) : 
		base (ctx, Resource.Layout.CarPreview, categories.ToArray()) 
		{
		}

		public override View GetView (int position, View itemView, ViewGroup parent)
		{
			var category = GetItem (position);

			if (itemView == null) {
				itemView = LayoutInflater
					.From (Context)
					.Inflate (Resource.Layout.CategoryPreview, parent, false);
			}

			// Lookup view for data population
			var name = (TextView) itemView.FindViewById(Resource.Id.cat_name);
			var desc = (TextView) itemView.FindViewById(Resource.Id.cat_desc);
			var img = (ImageView) itemView.FindViewById(Resource.Id.cat_pic);

			// Populate the data into the template view using the data object
			name.Text = category.Name;
			desc.Text = category.Description;
			img.SetImageResource (CategoryPicture(category.Id));

			// Return the completed view to render on screen
			return itemView;
		}

		int CategoryPicture (string id)
		{
			switch (id) {
			case "001":
				return Resource.Drawable.i001;
			case "002":
				return Resource.Drawable.i002;
			case "003":
				return Resource.Drawable.i003;
			case "004":
				return Resource.Drawable.i004;
			case "005":
				return Resource.Drawable.i005;
			case "006":
				return Resource.Drawable.i006;
			default :
				return Resource.Drawable.Icon;
			} 
		}
	}
}

