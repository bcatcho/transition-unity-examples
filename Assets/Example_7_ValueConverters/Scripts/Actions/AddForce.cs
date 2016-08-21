using Transition;
using Shared;
using UnityEngine;

namespace Example_7.Actions
{
	/// <summary>
	/// AddForce will add the force (described by Vec) to the attached rigidbody
	/// </summary>
	public class AddForce : Action<SimpleUnityContext>
	{
		public Vector3 Vec { get; set; }

		protected override TickResult OnTick (SimpleUnityContext context)
		{
			var rigidbody = context.Transform.GetComponent<Rigidbody2D>();
			rigidbody.AddForce(Vec);

			return TickResult.Done();
		}
	}
}