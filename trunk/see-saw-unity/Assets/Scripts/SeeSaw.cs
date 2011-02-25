using UnityEngine;
using System.Collections;

public class SeeSaw : MonoBehaviour 
{
    const float MoveSpeed = 5.0F;

	// Use this for initialization
	void Start () 
    {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
        if (Input.GetButton("D"))
        {
            hingeJoint.transform.position -= Vector3.right * MoveSpeed * Time.deltaTime;
        }
        else if (Input.GetButton("A"))
        {
            hingeJoint.transform.position += Vector3.right * MoveSpeed * Time.deltaTime;  
        }
	
	}
}
