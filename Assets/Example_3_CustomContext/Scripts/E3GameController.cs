using UnityEngine;
using Example_3.Actions;

namespace Example_3
{
   public class E3GameController : MonoBehaviour
   {
      public E3MachineController MachineController;

      [Multiline(8)]
      public string MachineDefOne;

      [Multiline(8)]
      public string MachineDefTwo;

      private void Awake()
      {
         MachineController = new E3MachineController();
         MachineController.LoadActions(typeof(Move));
         MachineController.Compile(MachineDefOne);
         MachineController.Compile(MachineDefTwo);
      }

      private void Update()
      {
         MachineController.TickAll();
      }

      public void AddAgent(E3Agent agent)
      {
         // adding an instance returns a context so that we can customize it
         var ctx = MachineController.AddMachineInstance(agent.MachineName);
         // setting the transform here will make it available in any action that uses this context
         ctx.Transform = agent.GetComponent<Transform>();
      }
   }
}