using System;

namespace App.Domain.Model
{
	public class Brand
	{
		public Brand (string label)
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
			var b = obj as Brand;
			if (b == null)
				return false;
			return Label.Equals (b.Label );
		}
	}
}

