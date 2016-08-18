using UnityEngine;
using Transition;
using Shared;

namespace Example_4.Actions
{
	/// <summary>
	/// This action will randomly transition based on generating a random number and rounding to the nearest int.
	/// </summary>
	public class RandomTransition : Action<SimpleUnityContext>
	{
		public TransitionDestination Zero { get; set; }

		public TransitionDestination One { get; set; }

		protected override TickResult OnTick (SimpleUnityContext context)
		{
			var randomInt = Mathf.RoundToInt(Random.Range(0f,1f));

			return randomInt == 0 ? TransitionTo(Zero) : TransitionTo(One);
		}
	}
}