using UnityEngine;
using System.Collections;

public class Weight : MonoBehaviour 
{
    const float MoveSpeed = 5.0F;
	
	// Use this for initialization
	void Start () 
	{
	}
	
	// Update is called once per frame
	void Update ()
	{
		if(Input.GetButton("W"))
		{
            transform.position += Vector3.up * MoveSpeed * Time.deltaTime;
		}		
		else if (Input.GetButton("S"))
		{
            transform.position -= Vector3.up * MoveSpeed * Time.deltaTime;
		}
	}
}
