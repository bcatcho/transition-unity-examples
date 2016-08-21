using UnityEngine;
using Transition.Compiler.ValueConverters;

namespace Example_7
{
	/// <summary>
	/// Converts a comma separated string of integers into a Vector3. This seems inefficient because it is. However
	/// this is only done once (at compile time).
	/// </summary>
	public class Vector3ValueConverter : IValueConverter
	{
		public System.Type GetConverterType ()
		{
			return typeof(Vector3);
		}

		public bool TryConvert (string input, out object result)
		{
			var components = input.Split (',');
			result = new Vector3 () {
				x = float.Parse (components [0]),
				y = float.Parse (components [1]),
				z = float.Parse (components [2]),
			};

			return true;
		}
	}
}