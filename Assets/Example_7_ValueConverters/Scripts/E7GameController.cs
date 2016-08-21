using UnityEngine;
using Shared;
using Example_7.Actions;

namespace Example_7
{
	/// <summary>
	/// Example 5 controller that is derived from a BaseController with some common fields
	/// </summary>
	public class E7GameController : BaseGameController
	{
		[Multiline (20)]
		public string MachineDefOne;

		private void Awake ()
		{
			MachineController = new SimpleUnityMachineController ();
			MachineController.LoadValueConverters (typeof(Vector3ValueConverter));
			MachineController.LoadActions (typeof(AddForce));
			MachineController.Compile (MachineDefOne);
		}

		private void Update ()
		{
			MachineController.TickAll ();
		}
	}
}