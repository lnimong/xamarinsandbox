using System;
using System.Collections.Generic;


namespace App.Common.ModelMVC
{
	public class MainMenuModelMVC
	{

		public MainMenuModelMVC ()
		{
			Links = new List<MenuLinkModelMVC>();

			RentService = new MenuLinkModelMVC ("louer une voiture", "CategoryListPage");
			Cars = new MenuLinkModelMVC ("acheter occasion", "CarListPage");
			MailUs = new MenuLinkModelMVC ("nous envoyer un mail", "MailPage");
			CallUs = new MenuLinkModelMVC ("nous appeler", "CallPage");
			AboutUs = new MenuLinkModelMVC ("en savoir plus", "AboutPage");

			Links.Add (RentService);
			Links.Add (Cars);
			Links.Add (AboutUs);
			Links.Add (CallUs);
			Links.Add (MailUs);
		}


		public IList<MenuLinkModelMVC> Links {
			get;
			private set;
		}

		public MenuLinkModelMVC RentService {
			get;
			private set;
		}

		public MenuLinkModelMVC Cars {
			get;
			private set;
		}

		public MenuLinkModelMVC AboutUs {
			get;
			private set;
		}


		public MenuLinkModelMVC CallUs {
			get;
			private set;
		}


		public MenuLinkModelMVC MailUs {
			get;
			private set;
		}

	}
}

