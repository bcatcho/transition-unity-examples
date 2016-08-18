using UnityEngine;
using Transition;

namespace Shared
{
	public class Say : Action<Context>
	{
		[DefaultParameter]
		public string Message { get; set; }

		protected override TickResult OnTick(Context context)
		{
			Debug.Log (Message);
			return TickResult.Done ();
		}
	}
}