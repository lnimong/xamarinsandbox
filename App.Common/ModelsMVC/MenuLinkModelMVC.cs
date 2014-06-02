using System;

namespace App.Common.ModelMVC
{
	public class MenuLinkModelMVC
	{
		public MenuLinkModelMVC (string label, string page)
		{
			Page = page;
			Label = label;
		}

		public string Page {
			get;
			private set;
		}

		public string Label {
			get;
			private set;
		}

	}
}

