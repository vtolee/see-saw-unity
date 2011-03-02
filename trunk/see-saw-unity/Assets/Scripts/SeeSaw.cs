using UnityEngine;
using System.Collections;

public class SeeSaw : MonoBehaviour 
{
    const float MoveSpeed = 5.0F;

	// Use this for initialization
	void Start () 
    {
		rigidbody.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezePositionZ;
		rigidbody.freezeRotation = true;		
	}
	
	// Update is called once per frame
	void Update () 
	{
        if (Input.GetButton("D"))
        {
			Vector3 moveAmt = Vector3.right * MoveSpeed * Time.deltaTime;
			hingeJoint.anchor -= moveAmt;
        }
        else if (Input.GetButton("A"))
        {
			Vector3 moveAmt = Vector3.right * MoveSpeed * Time.deltaTime;
			hingeJoint.anchor += moveAmt;
		}
		else if (Input.GetButton("Space"))
		{
			rigidbody.constraints = 0;
			rigidbody.constraints = RigidbodyConstraints.FreezePositionX;
		}
	}
}
