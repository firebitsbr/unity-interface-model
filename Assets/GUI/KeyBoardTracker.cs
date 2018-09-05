using UnityEngine;
using System.Collections;

public class KeyBoardTracker : ScriptableObject
{
    public enum WASDState
    {
        up = 1,
        down = 2,
        right = 4,
        left = 8
    }

    WASDState GetState()
    {
        WASDState state = new WASDState();

        if (Input.GetKey(KeyCode.W))
        {
            state |= WASDState.up;
        }

        if (Input.GetKey(KeyCode.S))
        {
            state |= WASDState.down;
        }

        if (Input.GetKey(KeyCode.D))
        {
            state |= WASDState.right;
        }

        if (Input.GetKey(KeyCode.A))
        {
            state |= WASDState.left;
        }

        return state;
    }
}