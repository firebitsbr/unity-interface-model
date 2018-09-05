using UnityEngine;
using System.Collections.Generic;

public interface IWeaponInventory
{
    CircularLinkedList<IWeapon> Weapons { get; set; }

    void AddWeapon(IWeapon weapon);

    void NextWeapon();

    void PrevWeapon();
}
