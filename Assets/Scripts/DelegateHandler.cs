using UnityEngine;
using System.Collections;

public class DelegateHandler : MonoBehaviour {


	//delegate <return-type> <delegate-name> (<Parameters list>)

	public delegate void ButtonClick();


	//event <delegate-name> <event-name>

	public static event ButtonClick Click;


	//On Button Click the event named Click can be called 
	public void OnButtonClick()
	{
		//call the event
		Click ();
	}
}
