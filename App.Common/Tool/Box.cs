using System;

namespace App.Common.Tool
{
	public static class Box
	{
		public static string Details(string car = null) {
			return Page ("DetailsPage", car);
		}

		public static string Buy(string car = null) {
			return Page ("BuyPage", car);
		}

		public static string Rent(string car = null) {
			return Page ("RentPage", car);
		}

		static string Page (string page, string car)
		{
			return  car  == null ? page : (page + "/" + car);
		}
	}
}

