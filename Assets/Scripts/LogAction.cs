using UnityEngine;
using Transition;





// to prevent boxing
public class TravelState
{
	public float Distance;
}

//public class Travel : Action<SimpleUnityContext>
//{
//	public float Distance { get; set; }
//
//	public float Speed { get; set; }
//
//	protected override void OnEnterAction (CustomContext context)
//	{
//		context.Distance = 0;
//	}
//
//	protected override TickResult OnTick (CustomContext context)
//	{
//		var tx = context.Tx;
//		var deltaPos = Vector3.right*Speed * Time.deltaTime;
//		var diff = Distance - ( context.Distance + deltaPos.magnitude);
//
//		if (diff < 0) {
//			tx.position += deltaPos + deltaPos.normalized * diff;
//			return TickResult.Done();
//		} else {
//			tx.position += deltaPos;
//			context.Distance += deltaPos.magnitude;
//		}
//
//		return TickResult.Yield();
//	}
//}