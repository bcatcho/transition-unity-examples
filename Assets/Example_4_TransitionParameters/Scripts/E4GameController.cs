using UnityEngine;
using Shared;
using Example_4.Actions;

namespace Example_4
{
	/// <summary>
	/// The Example 4 Game Controller builds off of Example 3 but hides shared functionality in BaseGameController
	/// </summary>
	public class E4GameController : BaseGameController
	{
		[Multiline (30)]
		public string MachineDefOne;

		private void Awake ()
		{
			MachineController = new SimpleUnityMachineController ();
			MachineController.LoadActions (typeof(Scale), typeof(Log), typeof(Wait), typeof(RandomTransition));
			MachineController.Compile (MachineDefOne);
		}

		private void Update ()
		{
			MachineController.TickAll ();
		}
	}
}