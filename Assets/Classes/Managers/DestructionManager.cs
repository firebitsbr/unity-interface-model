using UnityEngine;
using System.Collections.Generic;

public class DestructionManager : ScriptableObject, IManager
{
    private ObjectHolder _objHold;

    public DestructionManager(ObjectHolder holder)
    {
        _objHold = holder;
    }

    public void OnStartManager() { }

    public void OnUpdateManager()
    {
        //check destroy lists, delete if needed
    }
}