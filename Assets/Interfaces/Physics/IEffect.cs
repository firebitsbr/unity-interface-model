using UnityEngine;
using System.Collections;

public interface IEffect
{
    Component Effect { get; }
    void SetEffect(Component effect);
    void PlayEffect();
}
