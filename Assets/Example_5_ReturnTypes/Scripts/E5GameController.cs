using UnityEngine;
using Shared;
using Example_5.Actions;

namespace Example_5
{
	/// <summary>
	/// Example 5 controller that is derived from a BaseController with some common fields
	/// </summary>
	public class E5GameController : BaseGameController
	{
		[Multiline (15)]
		public string MachineDefOne;

		[Multiline (15)]
		public string MachineDefTwo;


		private void Awake ()
		{
			MachineController = new SimpleUnityMachineController ();
			MachineController.LoadActions (typeof(LongRunningAction), typeof(Loop));
			MachineController.LoadActions (typeof(Scale), typeof(Log), typeof(Wait));
			MachineController.Compile (MachineDefOne);
			MachineController.Compile (MachineDefTwo);
		}

		private void Update ()
		{
			MachineController.TickAll ();
		}
	}
}