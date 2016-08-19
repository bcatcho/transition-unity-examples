using UnityEngine;
using Transition;
using Shared;

namespace Example_1
{
   public class E1GameController : MonoBehaviour
   {
      public DefaultMachineController MachineController;

      public string MachineName;

      [Multiline(8)]
      public string MachineDef;

      private void Awake()
      {
         MachineController = new DefaultMachineController();
			MachineController.LoadActions(typeof(Say));
         MachineController.Compile(MachineDef);

         MachineController.AddMachineInstance(MachineName);
      }

      private void Update()
      {
         MachineController.TickAll();
      }
   }
}