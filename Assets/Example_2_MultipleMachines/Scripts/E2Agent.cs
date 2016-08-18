using UnityEngine;

namespace Example_2
{
   public class E2Agent : MonoBehaviour
   {
      public string MachineName;
      public E2GameController GameController;

      public void Start()
      {
         GameController.AddAgent(this);
      }
   }
}