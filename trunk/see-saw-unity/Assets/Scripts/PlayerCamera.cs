using UnityEngine;
using System.Collections;

public class PlayerCamera : MonoBehaviour
{
    const float m_fPlayerMoveCamSpeed = 5.0f;
    const float m_fPosYOS = 1.0f;
    const float m_fLookAtYOS = 1.25f;

    Vector3 m_vCurrLookAt;

    void Start()
    {
        Vector3 playerPos = GameObject.FindWithTag("Player").transform.position;
        Vector3 newPos = new Vector3(playerPos.x, playerPos.y + m_fPosYOS, transform.position.z);
        transform.position = newPos;

        m_vCurrLookAt = new Vector3(playerPos.x, playerPos.y + m_fLookAtYOS, playerPos.z);
        transform.LookAt(m_vCurrLookAt);
    }

    void Update()
    {
        if (!Game.g_bLaunchStarted)
        {
            // "pan"
	        if (Input.GetButton("Left"))
	        {
                m_vCurrLookAt += Vector3.right * m_fPlayerMoveCamSpeed * Time.deltaTime;
	        }
	        else if (Input.GetButton("Right"))
	        {
                m_vCurrLookAt -= Vector3.right * m_fPlayerMoveCamSpeed * Time.deltaTime;
            }
            // "zoom"
            if (Input.GetButton("Forward"))
            {
                transform.position -= Vector3.forward * m_fPlayerMoveCamSpeed * Time.deltaTime;
            }
            else if (Input.GetButton("Backward"))
            {
                transform.position += Vector3.forward * m_fPlayerMoveCamSpeed * Time.deltaTime;
            }
        }
        else
        {
            Vector3 newLookAt = GameObject.FindWithTag("Player").transform.position;
            m_vCurrLookAt = new Vector3(newLookAt.x, newLookAt.y + m_fLookAtYOS, newLookAt.z);
        }

        Vector3 newPos = new Vector3(m_vCurrLookAt.x, m_vCurrLookAt.y + m_fPosYOS, transform.position.z);
        transform.position = newPos;

        transform.LookAt(m_vCurrLookAt);
    }
}