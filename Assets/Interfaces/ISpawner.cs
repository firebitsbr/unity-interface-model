using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Object = UnityEngine.Object;


public delegate void CollisionActionDelegate(IColldiable first, IColldiable second);
public delegate void AddObjDelegate(IObject obj);

public interface ISpawner
{
    Dictionary<string, Object> Prefabs { get; }
    void LoadPrefabs();
    GameObject SpawnGameObject(string name, Vector2 pos, Quaternion rot);
    void Spawn(IObject obj, string name, Vector2 pos, Quaternion rot);
    CollisionActionDelegate CollAct { get; }
    AddObjDelegate AddObj { get; }
    void SetCollisionAction(CollisionActionDelegate func);
    void SetAddObj(AddObjDelegate func);

    //pick update delegate from obj and add to corresponding event
    void PickUpdate(IUpdatable obj);
}

