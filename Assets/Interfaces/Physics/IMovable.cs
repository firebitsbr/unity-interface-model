using UnityEngine;
using System.Collections;

 
public interface IMovable : IRigidbody2D, ITransform
{
    void SetVelocity(Vector2 vel);

    void SetForce(Vector2 dir);
}
 
