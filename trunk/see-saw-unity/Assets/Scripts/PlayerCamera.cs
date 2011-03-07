using UnityEngine;
using System.Collections;

public class PlayerCamera : MonoBehaviour
{
    const float MoveCamSpeed = 5.0f;
    const float PosYOffset = 1.0f;
    const float LookAtYOffset = 1.25f;
    const float MaxZDist = 2.0f;

    float m_fCurrZDist;

    Vector3 m_vCurrLookAt;

    void Start()
    {
        Vector3 playerPos = GameObject.FindWithTag("Player").transform.position;
        Vector3 newPos = new Vector3(playerPos.x, playerPos.y + PosYOffset, transform.position.z);
        transform.position = newPos;

        m_vCurrLookAt = new Vector3(playerPos.x, playerPos.y + LookAtYOffset, playerPos.z);
        transform.LookAt(m_vCurrLookAt);

        m_fCurrZDist = 0.0f;
    }

    void Update()
    {
        if (Input.GetButtonDown("R"))
        {
            m_fCurrZDist = 0.0f;
        }

        if (!Game.g_bLaunchStarted)
        {
            // "pan"
	        if (Input.GetButton("Left"))
	        {
                m_vCurrLookAt += Vector3.right * MoveCamSpeed * Time.deltaTime;
	        }
	        else if (Input.GetButton("Right"))
	        {
                m_vCurrLookAt -= Vector3.right * MoveCamSpeed * Time.deltaTime;
            }
            // "zoom"
            if (Input.GetButton("Forward") && m_fCurrZDist > -MaxZDist)
            {
                m_fCurrZDist -= MoveCamSpeed * Time.deltaTime;
                transform.position -= Vector3.forward * MoveCamSpeed * Time.deltaTime;
            }
            else if (Input.GetButton("Backward") && m_fCurrZDist < MaxZDist)
            {
                m_fCurrZDist += MoveCamSpeed * Time.deltaTime;
                transform.position += Vector3.forward * MoveCamSpeed * Time.deltaTime;
            }
        }
        else
        {
            Vector3 newLookAt = GameObject.FindWithTag("Player").transform.position;
            m_vCurrLookAt = new Vector3(newLookAt.x, newLookAt.y + LookAtYOffset, newLookAt.z);
        }

        Vector3 newPos = new Vector3(m_vCurrLookAt.x, m_vCurrLookAt.y + PosYOffset, transform.position.z);
        transform.position = newPos;

        transform.LookAt(m_vCurrLookAt);
    }
}