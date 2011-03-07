using UnityEngine;
using System.Collections;

public class Weight : MonoBehaviour 
{
    const float MoveSpeed = 3.0f;
    const float MaxMoveDist = 1.35f;

    float m_fCurrMoveDist;
	
	void Start () 
	{
        m_fCurrMoveDist = 0.0f;
	}
	
	void Update ()
	{
		if (!Game.g_bLaunchStarted)
		{
            if (Input.GetButton("W") && m_fCurrMoveDist < MaxMoveDist)
			{
                m_fCurrMoveDist += MoveSpeed * Time.deltaTime;
                transform.position += Vector3.up * MoveSpeed * Time.deltaTime;
			}		
			else if (Input.GetButton("S") && m_fCurrMoveDist > -MaxMoveDist)
			{
                m_fCurrMoveDist -= MoveSpeed * Time.deltaTime;
                transform.position -= Vector3.up * MoveSpeed * Time.deltaTime;
            }
            else if (Input.GetButtonDown("Space"))
            {
                rigidbody.freezeRotation = false;
                rigidbody.constraints = 0;
                rigidbody.constraints = RigidbodyConstraints.FreezePositionZ;
                rigidbody.useGravity = true;
            }
		}
        else if (Input.GetButtonDown("R"))
        {
            m_fCurrMoveDist = 0.0f;
        }
	}
}
