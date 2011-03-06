using UnityEngine;
using System.Collections;

public class SeeSaw : MonoBehaviour
{
    const float MoveSpeed = 1.5F;
    const float MaxMoveDist = 0.25f;

    float m_fCurrMoveDist;

	void Start () 
    {
		rigidbody.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezePositionZ;
		rigidbody.freezeRotation = true;
        m_fCurrMoveDist = 0.0f;
    }
	
	void Update () 
	{
        if (!Game.g_bLaunchStarted)
        {
            if (Input.GetButton("D") && m_fCurrMoveDist > -MaxMoveDist)
            {
                m_fCurrMoveDist -= MoveSpeed * Time.deltaTime;
                Vector3 moveAmt = Vector3.right * MoveSpeed * Time.deltaTime;
                hingeJoint.anchor -= moveAmt;
            }
            else if (Input.GetButton("A") && m_fCurrMoveDist < MaxMoveDist)
            {
                m_fCurrMoveDist += MoveSpeed * Time.deltaTime;
                Vector3 moveAmt = Vector3.right * MoveSpeed * Time.deltaTime;
                hingeJoint.anchor += moveAmt;
            }
            else if (Input.GetButton("Space"))
            {
                rigidbody.constraints = 0;
                rigidbody.constraints = RigidbodyConstraints.FreezePositionX;
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
