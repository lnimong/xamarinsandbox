using System;
using System.Collections.Generic;

namespace App.Common.ModelMVC
{
	public class ServicesModelMVC
	{
		public ServicesModelMVC ()
		{
			Links = new List<MenuLinkModelMVC>();
			Links.Add (new MenuLinkModelMVC ("Acheter une Voiture", "BuyPage"));
			Links.Add (new MenuLinkModelMVC ("Louer une voiture", "RentPage"));
		}


		public IList<MenuLinkModelMVC> Links {
			get;
			private set;
		}
	}
}

