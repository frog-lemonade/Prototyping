using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Events;

public class PrototypeManager : MonoBehaviour
{
    public PlayerWorldData P1;
    public PlayerWorldData P2;

    public UnityEvent onP1;
    public UnityEvent onP2;

    bool _isWorldOneActive = true;
    Interactable _focus;

    // Start is called before the first frame update
    void Start()
    {
        ChangeWorld(true);
    }

    public void OnSwitch() => ChangeWorld(!_isWorldOneActive);
    internal void ChangeFocus(Interactable newFocus) => _focus = newFocus;

    void ChangeWorld(bool isWorldOneActive) {
        _isWorldOneActive = isWorldOneActive;

        if (_isWorldOneActive) {
            //P1.input.SwitchCurrentControlScheme("KeyboardMouse");
            P1.player.transform.localPosition = P2.player.transform.localPosition;
            P1.player.transform.rotation = P2.player.transform.rotation;
            P2.player.SendMessage("MoveInput", Vector2.zero);
        } else {
            //P2.input.SwitchCurrentControlScheme("KeyboardMouse");
            P2.player.transform.localPosition = P1.player.transform.localPosition;
            P2.player.transform.rotation = P1.player.transform.rotation;
            P1.player.SendMessage("MoveInput", Vector2.zero);
        }

        P1.world.SetActive(isWorldOneActive);
        P2.world.SetActive(!isWorldOneActive);

        if (_isWorldOneActive)
            onP1.Invoke();
        else
            onP2.Invoke();
    }

    /** Controls **/
    public void OnMove(InputValue value) {
        if (_isWorldOneActive)
            P1.player.SendMessage("OnMove", value);
        else
            P2.player.SendMessage("OnMove", value);
    }

    public void OnLook(InputValue value) {
        if (_isWorldOneActive)
            P1.player.SendMessage("OnLook", value);
        else
            P2.player.SendMessage("OnLook", value);
    }

    public void OnJump(InputValue value) {
        if (_isWorldOneActive)
            P1.player.SendMessage("OnJump", value);
        else
            P2.player.SendMessage("OnJump", value);
    }

    public void OnSprint(InputValue value) {
        if (_isWorldOneActive)
            P1.player.SendMessage("OnSprint", value);
        else
            P2.player.SendMessage("OnSprint", value);
    }

    public void OnUse() {
        if (_focus != null)
            _focus.DoAction();
    }

    [System.Serializable]
    public struct PlayerWorldData {
        public GameObject world;
        public GameObject player;
        public PlayerInput input;
    }
}
