using UnityEngine;
using System.Collections;

public class ResetTransforms : MonoBehaviour
{
    Quaternion vOriginalRotation;
    Vector3 vOriginalPosition;

    // Initialization
    void Start()
    {
        vOriginalRotation = transform.rotation;
        vOriginalPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Space"))
        {
        }
        else if (Input.GetButtonDown("R"))
        {
            // reset position & rotation
            transform.rotation = vOriginalRotation;
            transform.position = vOriginalPosition;
        }
    }
}