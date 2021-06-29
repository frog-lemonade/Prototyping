using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class OverrideInput : MonoBehaviour
{
    public PlayerInput P1;
    public PlayerInput P2;

    // Start is called before the first frame update
    void Start()
    {
        P1.SwitchCurrentControlScheme("KeyboardMouse");
        P2.SwitchCurrentControlScheme("Keyboard2");
    }
}
