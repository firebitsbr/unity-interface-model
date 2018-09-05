using UnityEngine;
using System.Collections;
using System;

class Arrow : IBullet
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

    private CollisionActionDelegate _collAct;
    public CollisionActionDelegate CollAct
    {
        get
        {
            return _collAct;
        }
    }

    public void SetCollisionAction(CollisionActionDelegate collAct)
    {
        _collAct = collAct;
    }

    private float _damage;

    public float Damage
    {
        get
        {
            return _damage;
        }

        set
        {
            _damage = value;
        }
    }

    private Rigidbody2D _rigidbody;

    public Rigidbody2D Rigidbody
    {
        get
        {
            return _rigidbody;
        }
    }

    public void SetRigidbody(Rigidbody2D rigidbody)
    {
        _rigidbody = rigidbody;
    }

    public void SetForce(Vector2 dir)
    {
        Rigidbody.AddForce(dir);
    }

    public void SetVelocity(Vector2 vel)
    {
        Rigidbody.velocity = vel;
    }

    public Arrow(float damage = 5f)
    {
        Damage = damage;
    }
}
