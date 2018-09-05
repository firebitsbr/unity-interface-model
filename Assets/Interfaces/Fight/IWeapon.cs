using UnityEngine;
using System.Collections;

public interface IWeapon : IObject, IEffect
{
    float AttackRate { get; set; }
    //registration attack oncollision
    void Attack();
}

