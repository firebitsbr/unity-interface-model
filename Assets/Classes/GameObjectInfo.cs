using UnityEngine;
using System.Collections;

public class GameObjectInfo : MonoBehaviour
{
    public IObject Owner;

    void OnCollisionEnter2D(Collision2D other)
    {
        IObject obj = other.gameObject.GetComponent<GameObjectInfo>().Owner;
        (Owner as IColldiable).CollAct(Owner as IColldiable, obj as IColldiable);
    }
}
