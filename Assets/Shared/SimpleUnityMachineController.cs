using Transition;

namespace Shared
{
   /// <summary>
   /// The only reason this class is necessary is to be able to specify a custom context.
   /// The context is specified by overriding the BuildContext factory method.
   /// </summary>
   public class SimpleUnityMachineController : MachineController<SimpleUnityContext>
   {
      public SimpleUnityMachineController() : base(500,1000)
      {
      }

      protected override SimpleUnityContext BuildContext()
      {
         return new SimpleUnityContext();
      }
   }
}