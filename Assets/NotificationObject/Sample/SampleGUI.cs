using UnityEngine;
using System.Collections;

namespace notificationObjectSample
{
	public class SampleGUI : MonoBehaviour
	{
		public TextMesh textMesh ;

		// Use this for initialization
		void Start ()
		{
			var sample = Sample.Instance.item;
			itemHandler(sample.Value);
			sample.action += itemHandler;
		}

		void OnDestroy()
		{
			if( Sample.Instance != null)
				Sample.Instance.item.action -= itemHandler;
		}
	
		void itemHandler (int arg0)
		{
			textMesh.text = arg0.ToString("00000");
		}
	}
}