using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ColorAndMovement : MonoBehaviour {

	public Text textposition,textcolor;

	//add the methods to events 
	void OnEnable () {
		DelegateHandler.Click += ChangePosition;
		DelegateHandler.Click += ChangeColor;
	}
	
	// Update is called once per frame
	void Update () {
	}

	//move the ball to right 
	void ChangePosition()
	{
		textposition.text = "Position Changed";
		transform.position = new Vector2 (transform.position.x + 1, transform.position.y);
	}

	//change the color of ball and text
	void ChangeColor()
	{
		Color color=new Color (Random.value, Random.value, Random.value);
		textcolor.text = "Color Changed";

		//set the color on ball and text
		transform.renderer.material.color = color;
		textcolor.color=color;
	}

	//remove the methods added before
	void OnDisable()
	{
		DelegateHandler.Click -= ChangePosition;
		DelegateHandler.Click -= ChangeColor;
	}
}
