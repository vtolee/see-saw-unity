using UnityEngine;
using System.Collections;

public class ResetTransformsRigidBody : MonoBehaviour 
{
	Quaternion vOriginalRotation;
	Vector3 vOriginalPosition;
    RigidbodyConstraints froze = RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezePositionX;

	// Use this for initialization
	void Start () 
	{
        rigidbody.constraints = froze;
		vOriginalRotation = transform.rotation;
		vOriginalPosition = transform.position;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetButtonDown("Space"))
        {
            rigidbody.freezeRotation = false;
            rigidbody.constraints = 0;
            rigidbody.constraints = RigidbodyConstraints.FreezePositionZ;
			rigidbody.useGravity = true;
		}
		else if (Input.GetButtonDown("R"))
        {
            rigidbody.useGravity = false;
            rigidbody.constraints = froze;
            rigidbody.freezeRotation = true;

            // reset position & rotation
            transform.position = vOriginalPosition;
			transform.rotation = vOriginalRotation;
			
			rigidbody.position = vOriginalPosition;
			rigidbody.rotation = vOriginalRotation;
			rigidbody.velocity += -rigidbody.velocity;
			rigidbody.angularVelocity += -rigidbody.angularVelocity;

		}
	}
}
