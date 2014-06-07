using UnityEngine;
using System.Collections;
using System;

public class NotificationObject<T> 
{

	private T data;
	
	public NotificationObject (T t)
	{
		Value = t;
	}
	
	public NotificationObject ()
	{}
	
	~NotificationObject ()
	{ 
		Dispose ();
	}
	 
	public UnityEngine.Events.UnityAction<T> action = null;

	public T Value {
		get {
			return data;
		}
		set {
			if( action != null )
				action(value);
			data = value;
		}
	}
	
	private void Notice ()
	{
		action (data);
	}
	
	public void Dispose ()
	{
		action = null;
	}
}