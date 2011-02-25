using UnityEngine;
using System.Collections;

public class Weight : MonoBehaviour 
{
	
	// Use this for initialization
	void Start () 
	{
	}
	
	// Update is called once per frame
	void Update ()
	{
		if(Input.GetButton("W"))
		{
			transform.position += Vector3.up * 5.0F * Time.deltaTime;
		}		
		else if (Input.GetButton("S"))
		{
			transform.position -= Vector3.up * 5.0F * Time.deltaTime;
		}
	}
}
