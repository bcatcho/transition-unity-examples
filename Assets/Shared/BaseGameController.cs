using UnityEngine;
using Shared;

namespace Shared
{
	/// <summary>
	/// A base controller task to remove repetitive elements from the examples
	/// </summary>
	public class BaseGameController : MonoBehaviour
	{
		public SimpleUnityMachineController MachineController;

		public void AddAgent (BaseAgent agent)
		{
			// adding an instance returns a context so that we can customize it
			var ctx = MachineController.AddMachineInstance (agent.MachineName);
			// setting the transform here will make it available in any action that uses this context
			ctx.Transform = agent.GetComponent<Transform> ();
		}
	}
}