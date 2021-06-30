using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    public GameObject helper;

    void Start() {
        helper.SetActive(false);
    }

    void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Player")) {
            helper.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other) {
        helper.SetActive(false);
    }
}
