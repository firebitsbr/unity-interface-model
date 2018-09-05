using UnityEngine;
using System.Collections;

interface ICreature : IObject, IUpdatable
{
    float CurHP { get; set; }
    float MaxHP { get; set; }
    void Damage(float damage);
    void Heal(float heal);
    void Die();
}

