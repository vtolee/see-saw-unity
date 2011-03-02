using UnityEngine;
using System.Collections;

public class Wedge : MonoBehaviour 
{
    const float MoveSpeed = 5.0F;

	// Use this for initialization
	void Start () 
	{
		rigidbody.freezeRotation = true;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetButton("A"))
		{
            transform.position += Vector3.right * MoveSpeed * Time.deltaTime;
		}
		if (Input.GetButton("D"))
		{
            transform.position -= Vector3.right * MoveSpeed * Time.deltaTime;
		}
	}
}
