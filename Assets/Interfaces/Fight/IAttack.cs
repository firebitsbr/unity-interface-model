using UnityEngine;
using System.Collections;

interface IAttack
{
    IWeapon Weapon { get; set; }

    ITransform FirePoint { get; set; }

    void Attack();
}

