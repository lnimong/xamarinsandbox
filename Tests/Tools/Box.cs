using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace Tests.Tools
{
	public static class Box
	{
		public static bool AreEquals<T> (IEnumerable<T> e1, IEnumerable<T> e2)
		{
			var count = e1.Count ();
			if (count != e2.Count ()) 
			{
				return false;
			}

			var a1 = e1.ToArray ();
			var a2 = e2.ToArray ();
			for (var i = 0; i < count; ++i) {
				if (a1 [i].Equals (a2 [i]) == false)
					return false;
			}

			return true;
		}
	}
}

