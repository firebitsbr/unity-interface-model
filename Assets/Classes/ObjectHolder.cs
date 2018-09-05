using UnityEngine;
using System.Collections.Generic;

public class ObjectHolder : ScriptableObject
{
    private List<ICreature> _creatures;
    private List<IThing> _objects;
    private IPlayer _player;
    private ITransform _background;

    private List<IObject> _destroyImmediate;
    private List<KeyValuePair<IObject, float>> _destroyOnTime;

    private List<KeyValuePair<IObject, IObject>> _collisions;

    public void AddObject(IObject obj)
    {
        //define type
        //add to corresponding list
        //by using magic
    }
}
