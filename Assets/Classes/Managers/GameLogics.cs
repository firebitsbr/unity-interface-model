using UnityEngine;
using System.Collections;
using System;

public delegate void OnUpdateDelegate();

class GameLogics : IManager
{
    public static event OnUpdateDelegate OnUpdate;
    private ObjectHolder _objHolder;

    public GameLogics(ObjectHolder holder)
    {
        _objHolder = holder;
    }

    public void OnStartManager() { }

    public void OnUpdateManager()
    {
        OnUpdate();
    }
}

