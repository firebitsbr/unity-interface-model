using UnityEngine;
using System.Collections;


interface IFollow : IMovable
{
    void GoToPoint(Vector2 dest);
}

