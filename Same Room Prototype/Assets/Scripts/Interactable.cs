using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.Events;

public class Interactable : MonoBehaviour
{
    public PrototypeManager manager;
    public GameObject helper;
    public UnityEvent action;

    void Start() {
        helper.SetActive(false);
    }

    public void DoAction() {
        action.Invoke();
    }

    void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Player")) {
            helper.SetActive(true);
            manager.ChangeFocus(this);
        }
    }

    void OnTriggerExit(Collider other) {
        helper.SetActive(false);
        manager.ChangeFocus(null);
    }
}
