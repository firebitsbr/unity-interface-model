using UnityEngine;
using System.Collections;

 
public interface IRigidbody2D : IObject
{
    Rigidbody2D Rigidbody { get; }
    void SetRigidbody(Rigidbody2D rigidbody);
}
 
