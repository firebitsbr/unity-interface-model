using UnityEngine;
using System.Collections;

public class CollisionManager : ScriptableObject, IManager
{
    private ObjectHolder _objHold;

    public CollisionManager(ObjectHolder holder)
    {
        _objHold = holder;
    }

    public void OnStartManager() { }

    public void OnUpdateManager()
    {
        //take collData from all objects
        //add to objholder
    }

    bool IsTouching(GameObject obj, string layer)
    {
        return obj.GetComponent<Rigidbody2D>().IsTouchingLayers(LayerMask.GetMask(layer));
    }

    public void CollisionAction(IColldiable first, IColldiable second)
    {
        //define types
        //call overloaded method
    }
}


