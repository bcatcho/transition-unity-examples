using UnityEngine;
using Transition;

namespace Shared
{
	/// <summary>
	/// A simple action that waits for a desired amount of seconds before moving to the next action
	/// </summary>
	public class Wait : Action<SimpleUnityContext>
	{
		[DefaultParameter]
		public float Seconds { get; set; }

		private static readonly string _bbVarName = "wait_duration";

		protected override void OnEnterAction (SimpleUnityContext context)
		{
			// See ValWrapper class for an explanaition
			if (!context.Blackboard.Exists (_bbVarName)) {
				var waitDuration = new ValWrapper<float>(0);
				context.Blackboard.Set<ValWrapper<float>> (_bbVarName, waitDuration);
			} else {
				var waitDuration = context.Blackboard.Get<ValWrapper<float>> (_bbVarName);
				waitDuration.Val = 0;
			}
		}

		protected override TickResult OnTick (SimpleUnityContext context)
		{
			var waitDuration = context.Blackboard.Get<ValWrapper<float>> (_bbVarName);
			waitDuration.Val += Time.deltaTime;

			// if we have exceeded the Seconds variable move on to the next Action 
			if (waitDuration.Val > Seconds) {
				return TickResult.Done ();
			}
			return TickResult.Yield ();
		}
	}
}