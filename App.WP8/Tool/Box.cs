using System;
using System.Collections.Generic;
using System.Linq;

namespace App.WP8.Tool
{
    public static class Box
    {
        public static Uri Page(string str)
        {

            var strs = str.Split('/');
            var page = strs[0];

            switch (page)
            {
                //case "CarListPage": 
                //	return new CarListActivity().Class;
                //case "CategoryListPage": 
                //	return new CategoryListActivity().Class;
                //case "AboutPage": 
                //	return new CarListActivity().Class;
                //case "MailPage": 
                //	return new MessageActivity().Class;
                case "CallPage":
                    return new Uri("/CallPage.xaml", UriKind.Relative);
                case "RentPage":
                    return new Uri(string.Format("/RentPage.xaml?categoryId={0}", strs[1]), UriKind.Relative);
                case "BuyPage":
                    return new Uri(string.Format("/BuyPage.xaml?carId={0}", strs[1]), UriKind.Relative);
                    //case "MainPage": 
                    //	return new MainActivity().Class;
            }
            return null;
        }

        public static Dictionary<string, string> ParseQuery(Uri uri)
        {
            if (uri.OriginalString.Contains("?"))
            {
                return uri.OriginalString.Split('?')[1].Split('&').ToDictionary(p =>
                {
                    return p.Split('=')[0];
                },
                    p =>
                {
                    return p.Split('=')[1];
                });
            }

            return null;
        }
    }
}

