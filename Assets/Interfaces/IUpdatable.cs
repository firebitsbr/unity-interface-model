using UnityEngine;
using System.Collections;

//can be redone eliminating izbitochnost' in IManager
//so as IManager is IUpdatable too
public interface IUpdatable
{
    void OnUpdate();
}

