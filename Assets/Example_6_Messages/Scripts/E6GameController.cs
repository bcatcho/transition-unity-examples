using UnityEngine;
using Shared;
using Example_6.Actions;

namespace Example_6
{
	/// <summary>
	/// Example 5 controller that is derived from a BaseController with some common fields
	/// </summary>
	public class E6GameController : BaseGameController
	{
		[Multiline (20)]
		public string MachineDefOne;

		private void Awake ()
		{
			MachineController = new SimpleUnityMachineController ();
			MachineController.LoadActions (typeof(Scale), typeof(IfBlue));
			MachineController.Compile (MachineDefOne);
		}

		private void Update ()
		{
			MachineController.TickAll ();
		}
	}
}