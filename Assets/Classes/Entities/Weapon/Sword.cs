using UnityEngine;
using System.Collections;
using System;

public class Sword : ScriptableObject, IMeleeWeapon
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

    private float _attackRate;

    public float AttackRate
    {
        get
        {
            return _attackRate;
        }

        set
        {
            _attackRate = value;
        }
    }

    private Component _effect;

    public Component Effect
    {
        get
        {
            return _effect;
        }
    }

    public void PlayEffect()
    {
        (Effect as ParticleSystem).Play();
    }

    public void SetEffect(Component effect)
    {
        _effect = effect;
    }

    private float _radius;

    public float Radius
    {
        get
        {
            return _radius;
        }

        set
        {
            _radius = value;
        }
    }

    public void Attack()
    {
       
    }
}