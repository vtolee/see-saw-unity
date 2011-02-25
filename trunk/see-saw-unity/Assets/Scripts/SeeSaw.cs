using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour 
{

	// Use this for initialization
	void Start () 
    {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
        if (Input.GetButton("D"))
        {
		    GameObject see_saw = GameObject.FindWithTag("seeSaw");
		    see_saw.hingeJoint.transform.position -= Vector3.right * 5.0F * Time.deltaTime;
        }
        else if (Input.GetButton("A"))
        {
            GameObject see_saw = GameObject.FindWithTag("seeSaw");
            see_saw.hingeJoint.transform.position += Vector3.right * 5.0F * Time.deltaTime;  
        }
	
	}
}
