using UnityEngine;
using Transition;

namespace Shared
{

	/// <summary>
	/// A simple class used to prevent boxing when casting Value types.
	/// </summary>
	public class ValWrapper<T>
	{
		public T Val { get; set; }

		public ValWrapper(T initialValue)
		{
			Val = initialValue;
		}
	}
}