using UnityEngine;
using UnityEditor;
using Shared;

public class MessageSender : EditorWindow
{
	public string MessageValue;
	public int RecipientContextId;
	public string MessageKey;

	[MenuItem ("Tools/MessageSender")]
	static void Init ()
	{
		// Get existing open window or if none, make a new one:
		MessageSender window = (MessageSender)EditorWindow.GetWindow (typeof(MessageSender));
		window.Show ();
	}

	void OnGUI ()
	{
		GUILayout.Label ("Base Settings", EditorStyles.boldLabel);
		MessageKey = EditorGUILayout.TextField ("Message Key", MessageKey);
		RecipientContextId = EditorGUILayout.IntField ("Recipient Id", RecipientContextId);
		MessageValue = EditorGUILayout.TextField ("Message Val", MessageValue);

		if (GUILayout.Button ("Send")) {
			var controller = Object.FindObjectOfType<BaseGameController>();
			controller.MachineController.SendMessage (MessageKey, RecipientContextId, MessageValue);
		}
	}
}