using System;

namespace App.Domain.Model
{
	public class Product
	{
		public Product (string label)
		{
			Label = label;
		}

		public string Label {
			get;
			private set;
		}

		public override int GetHashCode ()
		{
			return base.GetHashCode ();
		}

		public override bool Equals (object obj)
		{
			var p = obj as Product;
			if (p == null)
				return false;
			return Label.Equals (p.Label );
		}
	}
}

