using UnityEngine;
using System.Collections;


public interface IColldiable : IRigidbody2D
{
    //CollisionData OnCollision(CollisionLayer layer);
    CollisionActionDelegate CollAct { get; }
    void SetCollisionAction(CollisionActionDelegate collAct);
}
