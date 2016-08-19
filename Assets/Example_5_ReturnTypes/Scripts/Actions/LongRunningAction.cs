using Transition;
using Shared;

namespace Example_5.Actions
{
	/// <summary>
	/// A simple and usless action that demonstrates the effect of returning yield.
	/// </summary>
	public class LongRunningAction : Action<SimpleUnityContext>
	{
		protected override TickResult OnTick (SimpleUnityContext context)
		{
			// this action will never exit on it's own. Returning yield ensures this action will be run again next tick
			return TickResult.Yield();
		}
	}
}