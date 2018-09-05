using UnityEngine;
using System.Collections;
using System;

class Grass : IBackground
{
    GameObject _gO;

    public GameObject GO
    {
        get
        {
            return _gO;
        }

        set
        {
            _gO = value;
        }
    }

    public Vector3 Position
    {
        get
        {
            return GO.transform.position;
        }

        set
        {
            GO.transform.position = value;
        }
    }

    public Quaternion Rotation
    {
        get
        {
            return GO.transform.rotation;
        }

        set
        {
            GO.transform.rotation = value;
        }
    }

    public Vector3 Scale
    {
        get
        {
            return GO.transform.localScale;
        }

        set
        {
            GO.transform.localScale = value;
        }
    }

    public Transform Transform
    {
        get
        {
            return GO.transform;
        }
    }
}

