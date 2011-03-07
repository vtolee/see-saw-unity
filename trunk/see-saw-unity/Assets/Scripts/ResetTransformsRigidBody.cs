using UnityEngine;
using System.Collections;

public class ResetTransformsRigidBody : MonoBehaviour 
{
	Quaternion vOriginalRotation;
	Vector3 vOriginalPosition;
    RigidbodyConstraints froze = RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezePositionX;

	void Start () 
	{
        rigidbody.constraints = froze;
		vOriginalRotation = transform.rotation;
		vOriginalPosition = transform.position;
	}
	
	void FixedUpdate () 
	{
		if (Input.GetButtonDown("R"))
        {
            // reset position & rotation
            transform.position = vOriginalPosition;
			transform.rotation = vOriginalRotation;
			
			rigidbody.position = vOriginalPosition;
			rigidbody.rotation = vOriginalRotation;
			rigidbody.velocity += -rigidbody.velocity;
            rigidbody.angularVelocity += -rigidbody.angularVelocity;

            rigidbody.useGravity = false;
            rigidbody.constraints = froze;
            rigidbody.freezeRotation = true;
		}
	}
}
