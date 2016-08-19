using UnityEngine;
using Shared;

namespace Shared
{
	/// <summary>
	/// A common Agent that will be used to demonstrate state machines
	/// </summary>
	public class BaseAgent : MonoBehaviour
	{
		public string MachineName;
		public BaseGameController GameController;
		public int Id;

		public void Start ()
		{
			Id = GameController.AddAgent (this);
		}

		/// <summary>
		/// Sends the Machine a message to the context that controls this agent
		/// </summary>
		public void SendMachineMessage (string messageName)
		{
			GameController.MachineController.SendMessage(messageName, Id, null);
		}
	}
}