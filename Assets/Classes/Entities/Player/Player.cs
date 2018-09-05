using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;

class Player : IPlayer
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

    private float _curHP;

    public float CurHP
    {
        get
        {
            return _curHP;
        }

        set
        {
            _curHP = (value > MaxHP) ? MaxHP : value;
        }
    }

    private float _maxHP;

    public float MaxHP
    {
        get
        {
            return _maxHP;
        }

        set
        {
            _maxHP = value;
        }
    }

    public void Damage(float damage)
    {
        CurHP -= damage;
    }

    public void Die()
    {
        throw new NotImplementedException();
    }

    public void Heal(float heal)
    {
        CurHP += heal;
    }

    private ITransform _firePoint;

    public ITransform FirePoint
    {
        get
        {
            return _firePoint;
        }

        set
        {
            _firePoint = value;
        }
    }

    private IWeapon _weapon;

    public IWeapon Weapon
    {
        get
        {
            return _weapon;
        }

        set
        {
            _weapon = value;
        }
    }

    public void Attack()
    {
        throw new NotImplementedException();
    }

    private Node<IWeapon> _curWeapon;

    private CircularLinkedList<IWeapon> _weapons = new CircularLinkedList<IWeapon>();

    public CircularLinkedList<IWeapon> Weapons
    {
        get
        {
            return _weapons;
        }

        set
        {
            _weapons = value;
        }
    }

    public void AddWeapon(IWeapon weapon)
    {
        Weapons.AddLast(weapon);
        if (_curWeapon == null)
            _curWeapon = Weapons.Head;
    }
    
    public void NextWeapon()
    {
        _curWeapon = _curWeapon.Next;
    }

    public void PrevWeapon()
    {
        _curWeapon = _curWeapon.Previous;
    }

    public void OnUpdate()
    {

    }
}

