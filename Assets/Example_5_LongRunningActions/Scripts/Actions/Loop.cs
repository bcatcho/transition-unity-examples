using Transition;
using Shared;

namespace Example_5.Actions
{
	public class Loop : Action<SimpleUnityContext>
	{
		protected override TickResult OnTick (SimpleUnityContext context)
		{
			return TickResult.Loop();
		}
	}
}