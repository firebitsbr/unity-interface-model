using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;


public class InitialSceneSpawner : ScriptableObject, IManager, ISpawner
{
    public delegate void AddObject(IObject obj);
    public delegate void Collide(IColldiable first, IColldiable second);

    private ObjectHolder _objHolder;
    private CollisionManager _collMan;

    private Dictionary<string, UnityEngine.Object> _objectPrefabs;

    public Dictionary<string, UnityEngine.Object> Prefabs
    {
        get
        {
            return _objectPrefabs;
        }
    }

    public CollisionActionDelegate CollAct
    {
        get
        {
            return _collMan.CollisionAction;
        }
    }
    public void SetCollisionAction(CollisionActionDelegate func) { }

    public AddObjDelegate AddObj
    {
        get
        {
            return _objHolder.AddObject;
        }
    }
    public void SetAddObj(AddObjDelegate func) { }
    public InitialSceneSpawner(ObjectHolder holder, CollisionManager collMan)
    {
        _objectPrefabs = new Dictionary<string, UnityEngine.Object>();
        _objHolder = holder;
        _collMan = collMan;
    }

    public void LoadPrefabs()
    {
        LoadPrefab("Amigo", "Players/");
        LoadPrefab("BadGuy", "Enemies/");
        LoadPrefab("Box", "Things/");
        LoadPrefab("Bow", "Weapons/");
        LoadPrefab("Sword", "Weapons/");
        LoadPrefab("Arrow", "Bullets/");
        LoadPrefab("Grass", "Backgrounds/");
    }

    void LoadPrefab(string name, string folder)
    {
        _objectPrefabs.Add(name, Resources.Load("Prefabs/" + folder + name));
    }

    public void OnStartManager()
    {
        LoadPrefabs();

        SpawnStartScene();
    }

    public void OnUpdateManager() { }

    public GameObject SpawnGameObject(string name, Vector2 pos, Quaternion rot)
    {
        return Instantiate(Prefabs[name], pos, rot) as GameObject;
    }

    public void Spawn(IObject obj, string name, Vector2 pos, Quaternion rot)
    {
        obj.GO = SpawnGameObject(name, pos, rot);
        AddObj(obj);
    }

    private void SpawnDefault(IObject obj, string name)
    {
        GameObject gObj = _objectPrefabs[name] as GameObject;
        Spawn(obj, name, gObj.transform.position, gObj.transform.rotation);
    }

    public void PickUpdate(IUpdatable obj)
    {
        GameLogics.OnUpdate += obj.OnUpdate;
    }

    void SpawnStartScene()
    {
        Grass grass = new Grass();
        SpawnDefault(grass, "Grass");

        Player player = new Player();
        SpawnDefault(player, "Amigo");

        Bow bow = new Bow();
        SpawnDefault(bow, "Bow");
        player.AddWeapon(bow);

        Sword sword = new Sword();
        SpawnDefault(sword, "Sword");
        player.AddWeapon(sword);

        BadGuy badGuy = new BadGuy();
        SpawnDefault(badGuy, "BadGuy");
    }
}
