using System;
using System.Linq;
using Android.Content;

namespace Android02.Tool
{
	public static class Box
	{
		private static Java.Lang.Class Page(string str) {

			var strs = str.Split ('/');
			var page = strs [0];

			switch (page) {
			case "CarListPage": 
				return new CarListActivity().Class;
			case "CategoryListPage": 
				return new CategoryListActivity().Class;
			case "AboutPage": 
				return new CarListActivity().Class;
			case "MailPage": 
				return new MessageActivity().Class;
			case "CallPage": 
				return new CallActivity().Class;
			case "RentPage":
				return new RentTheCarActivity ().Class;
			case "BuyPage":
				return new BuyTheCarActivity ().Class;
			case "MainPage": 
				return new MainActivity().Class;
			}
			return null;
		}

		static string Param (string url)
		{
			var strs = url.Split ('/');
			var param = strs.Count() > 1 ?  strs[1] : string.Empty;
			return param;
		}

		public static void NavigateTo(this Android.Content.Context ctx, string url) {
			var intent = new Intent (ctx, Page (url));
			var param = Param (url);

			if (string.IsNullOrEmpty (param) == false) {
				intent.PutExtra ("param", param);
			}

			ctx.StartActivity (intent);
		}
	}
}

