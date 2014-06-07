using UnityEngine;
using System.Collections;

namespace notificationObjectSample
{
	public class Sample : MonoBehaviour
	{
		public static Sample Instance
		{
			get{
				if( instance == null)
					instance = GameObject.FindObjectOfType<Sample>();
				return instance;
			}
		}
		private static Sample instance = null;

		public NotificationObject<int> item = new NotificationObject<int>(){ Value = 2 };

		void OnGUI ()
		{
			if (GUILayout.Button ("add")) {
				item.Value += 1;
			}
		}
	}
}
