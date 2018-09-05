using UnityEngine;
using System.Collections;

 
public interface ITransform : IObject
{
    Transform Transform { get; }
    Vector3 Position { get; set; }
    Quaternion Rotation { get; set; }
    Vector3 Scale { get; set; }
}
 
