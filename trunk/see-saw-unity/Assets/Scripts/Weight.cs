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
		if(Input.GetButtonDown("W"))
		{
			transform.position += Vector3.up * 10.0F * Time.deltaTime;
		}		
	}
}
