using UnityEngine;

namespace Example_3
{
   public class E3Agent : MonoBehaviour
   {
      public string MachineName;
      public E3GameController GameController;

      public void Start()
      {
         GameController.AddAgent(this);
      }
   }
}