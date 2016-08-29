using Transition;

namespace Example_3
{
   /// <summary>
   /// The only reason this class is necessary is to be able to specify a custom context.
   /// The context is specified by overriding the BuildContext factory method.
   /// </summary>
   public class E3MachineController : MachineController<E3Context>
   {
      public E3MachineController() : base(100,100)
      {
      }

      protected override E3Context BuildContext()
      {
         return new E3Context();
      }
   }
}