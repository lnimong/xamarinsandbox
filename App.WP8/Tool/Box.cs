using System;
using System.Linq;

namespace App.WP8.Tool
{
	public static class Box
	{
		public static Uri Page(string str) {

			var strs = str.Split ('/');
			var page = strs [0];

			switch (page) {
                //case "CarListPage": 
                //	return new CarListActivity().Class;
                //case "CategoryListPage": 
                //	return new CategoryListActivity().Class;
                //case "AboutPage": 
                //	return new CarListActivity().Class;
                //case "MailPage": 
                //	return new MessageActivity().Class;
                //case "CallPage": 
                //	return new CallActivity().Class;
                case "RentPage":
                    return new Uri("/RentPage.xaml");
                    //case "BuyPage":
                    //	return new BuyTheCarActivity ().Class;
                    //case "MainPage": 
                    //	return new MainActivity().Class;
            }
			return null;
		}
	}
}

