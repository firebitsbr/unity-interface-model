using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;

public class Bow : ScriptableObject, IRangeWeapon
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

    private float _flyDistance;

    public float FlyDistance
    {
        get
        {
            return _flyDistance;
        }

        set
        {
            _flyDistance = value;
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

    public void Attack()
    {

    }

    private AddObjDelegate _addObj;
    public AddObjDelegate AddObj
    {
        get
        {
            return _addObj;
        }
    }

    public void SetAddObj(AddObjDelegate func)
    {
        _addObj = func;
    }
    private CollisionActionDelegate _collAct;
    public CollisionActionDelegate CollAct
    {
        get
        {
            return _collAct;
        }
    }

    public void SetCollisionAction(CollisionActionDelegate func)
    {
        _collAct = func;
    }

    private Dictionary<string, UnityEngine.Object> _prefabs;
    public Dictionary<string, UnityEngine.Object> Prefabs
    {
        get
        {
            return _prefabs;
        }
    }

    public void LoadPrefabs()
    {
        LoadPrefab("Arrow", "Bullets/");
    }

    void LoadPrefab(string name, string folder)
    {
        _prefabs.Add(name, Resources.Load("Prefabs/" + folder + name));
    }

    public void PickUpdate(IUpdatable obj)
    {
        GameLogics.OnUpdate += obj.OnUpdate;
    }

    public GameObject SpawnGameObject(string name, Vector2 pos, Quaternion rot)
    {
        return Instantiate(Prefabs[name], pos, rot) as GameObject;
    }

    public void Spawn(IObject obj, string name, Vector2 pos, Quaternion rot)
    {
        obj.GO = SpawnGameObject(name, pos, rot);
        AddObj(obj);
    }
}