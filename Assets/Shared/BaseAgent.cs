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

		public void Start ()
		{
			GameController.AddAgent (this);
		}
	}
}