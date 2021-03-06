using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SymbolButton : MonoBehaviour
{
    AudioSource audioSource;

    void Start() {
        audioSource = GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider other) {
        if(other.CompareTag("HearingPlayer"))
        {
            audioSource.Play();
        }
    }
}
