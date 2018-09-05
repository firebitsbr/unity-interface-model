using UnityEngine;
using System.Collections;

interface IBullet : IMovable, IColldiable
{
    float Damage { get; set; }
}

