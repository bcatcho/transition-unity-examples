using UnityEngine;
using Transition;
using Shared;

namespace Example_2
{
   public class E2GameController : MonoBehaviour
   {
      public DefaultMachineController MachineController;

      [Multiline(8)]
      public string MachineDefOne;

      [Multiline(8)]
      public string MachineDefTwo;

      private void Awake()
      {
         MachineController = new DefaultMachineController();
         MachineController.LoadActions(typeof(Say));
         MachineController.Compile(MachineDefOne);
         MachineController.Compile(MachineDefTwo);
      }

      private void Update()
      {
         MachineController.TickAll();
      }

      public void AddAgent(E2Agent agent)
      {
         MachineController.AddMachineInstance(agent.MachineName);
      }
   }
}