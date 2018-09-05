using UnityEngine;
using System.Collections;

public class MouseTracker : ScriptableObject
{
    public Vector3 MousePosition
    {
        get
        {
            return Input.mousePosition;
        }
    }

    public bool LMBPressed
    {
        get
        {
            return (Input.GetMouseButton(0));
        }
    }

    public bool RMBPressed
    {
        get
        {
            return (Input.GetMouseButton(1));
        }
    }
}
