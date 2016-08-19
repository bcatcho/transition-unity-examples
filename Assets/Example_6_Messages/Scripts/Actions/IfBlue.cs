using Transition;
using Shared;
using UnityEngine;

namespace Example_6.Actions
{
	/// <summary>
	/// This class will check to see if the blue value of the attached sprite is blue enough.
	/// It will transition to the state assigned to Yes, or do nothing.
	/// </summary>
	public class IfBlue : Action<SimpleUnityContext>
	{
		public TransitionDestination Yes { get; set; }
		
		protected override TickResult OnTick (SimpleUnityContext context)
		{
			var color = context.Transform.GetComponent<SpriteRenderer>().color;
			if (color.b > .99f) {
				return TransitionTo(Yes);
			}

			return TickResult.Done();
		}
	}
}