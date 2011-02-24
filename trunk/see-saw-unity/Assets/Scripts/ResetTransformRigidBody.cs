using UnityEngine;
using System.Collections;

public class ResetTransformRigidBody : MonoBehaviour 
{
	Quaternion vOriginalRotation;
	Vector3 vOriginalPosition;

	// Use this for initialization
	void Start () 
	{
		vOriginalRotation = transform.rotation;
		vOriginalPosition = transform.position;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetButtonDown("Space"))
		{
			rigidbody.useGravity = true;
		}
		else if (Input.GetButtonDown("R"))
		{
			// reset position
			transform.position = vOriginalPosition;
			transform.rotation = vOriginalRotation;
			rigidbody.velocity = Vector3.zero;
			rigidbody.angularVelocity = Vector3.zero;
			rigidbody.useGravity = false;
		}
	}
}
