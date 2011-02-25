using UnityEngine;
using System.Collections;

public class ResetCharacter : MonoBehaviour 
{

	Quaternion vOriginalRotation;
	Vector3 vOriginalPosition;
	
	// Use this for initialization
	void Start () 
	{
		vOriginalPosition = new Vector3(-0.5540707F, -0.3825212F, -0.005848927F);
		vOriginalRotation = new Quaternion(86.93126F, 92.32443F, 2.600914F, 1.0F);
	}
	
	// Update is called once per frame
	void Update () 
	{	
		if(Input.GetButtonDown("Space"))
		{
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
		}
	}
}
