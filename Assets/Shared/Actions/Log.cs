using UnityEngine;
using Transition;

namespace Shared
{

	public class Log : Action<SimpleUnityContext>
	{
		[DefaultParameter]
		public string Message { get; set; }

		protected override TickResult OnTick(SimpleUnityContext context)
		{
			Debug.Log (Message);
			return TickResult.Done ();
		}
	}
}