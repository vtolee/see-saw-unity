using UnityEngine;
using System.Collections;

public class Game : MonoBehaviour
{
    public static bool g_bLaunchStarted = false;

    void Start()
    {
        renderer.enabled = false;
    }

    void Update()
    {
    }

    void LateUpdate()
    {
        if (Input.GetButtonDown("R"))
        {
            g_bLaunchStarted = false;
        }
        else if (Input.GetButtonDown("Space"))
        {
            g_bLaunchStarted = true;
        }
    }
}