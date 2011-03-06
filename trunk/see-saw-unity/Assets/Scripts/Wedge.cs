using UnityEngine;
using System.Collections;

public class Wedge : MonoBehaviour 
{
    const float MoveSpeed = 1.5F;
    const float MaxMoveDist = 0.25f;

    float m_fCurrMoveDist;

	void Start () 
	{
		rigidbody.freezeRotation = true;
        m_fCurrMoveDist = 0.0f;
	}
	
	void Update () 
	{
        if (!Game.g_bLaunchStarted)
        {
            if (Input.GetButton("A") && m_fCurrMoveDist < MaxMoveDist)
            {
                m_fCurrMoveDist += MoveSpeed * Time.deltaTime;
                transform.position += Vector3.right * MoveSpeed * Time.deltaTime;
            }
            if (Input.GetButton("D") && m_fCurrMoveDist > -MaxMoveDist)
            {
                m_fCurrMoveDist -= MoveSpeed * Time.deltaTime;
                transform.position -= Vector3.right * MoveSpeed * Time.deltaTime;
            }
        }
        else
        {
            if (Input.GetButtonDown("R"))
            {
                m_fCurrMoveDist = 0.0f;
            }
        }
	}
}
