using UnityEngine;
using Transition;

namespace Shared
{

	public class Scale : Action<SimpleUnityContext>
	{
		[DefaultParameter]
		public float UniformScale { get; set; }

		protected override TickResult OnTick (SimpleUnityContext context)
		{
			context.Transform.localScale *= UniformScale;
			return TickResult.Done();
		}
	}
}