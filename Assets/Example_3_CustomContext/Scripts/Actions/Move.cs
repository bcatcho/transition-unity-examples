using UnityEngine;
using Transition;

namespace Example_3.Actions
{
   public class Move : Action<E3Context>
   {
      public float Speed { get; set; }

      protected override TickResult OnTick(E3Context context)
      {
         // this transform value is set by the Controller when an agent is added
         context.Transform.position += Vector3.right * Speed * Time.deltaTime;
         // returning yield ensures we never leave this action.
         return TickResult.Yield();
      }
   }
}