using UnityEngine;
using System.Collections;


interface IMeleeWeapon : IWeapon
{
    float Damage { get; set; }
    float Radius { get; set; }
}
