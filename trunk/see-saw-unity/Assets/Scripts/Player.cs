using UnityEngine;
using System.Collections;



public class Player : MonoBehaviour
{

    // Initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Space"))
        {
            rigidbody.freezeRotation = false;
            rigidbody.constraints = 0;
            rigidbody.constraints = RigidbodyConstraints.FreezePositionZ;
            rigidbody.useGravity = true;
        }
    }
}