using UnityEngine;
using System.Collections;

public class ResetTransformsRigidBody : MonoBehaviour 
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
			//rigidbody.isKinematic =false;
			rigidbody.useGravity = true;
			rigidbody.freezeRotation = false;
		}
		else if (Input.GetButtonDown("R"))
		{
			// reset position & rotation
			transform.rotation = vOriginalRotation;
			transform.position = vOriginalPosition;
			
			rigidbody.position = vOriginalPosition;
			rigidbody.rotation = vOriginalRotation;
			rigidbody.velocity += -rigidbody.velocity;
			rigidbody.angularVelocity += -rigidbody.angularVelocity;

			rigidbody.useGravity = false;
			rigidbody.freezeRotation = true;
			//rigidbody.isKinematic = true;
		}
	}
}
