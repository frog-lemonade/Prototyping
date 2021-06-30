using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DangerTrapdoor : MonoBehaviour
{
    private Rigidbody rb;

    public float timeToDrop = 2f;
    private float currentTimeToDrop = 0f;
    private bool makingContact = false;
    AudioSource aud;
    private void Start() {
        rb = GetComponent<Rigidbody>();
        rb.constraints = RigidbodyConstraints.FreezePosition;
        aud = GetComponent<AudioSource>();
    }
    void OnTriggerEnter(Collider other) {
        if(other.gameObject.CompareTag("SeeingPlayer") || other.gameObject.CompareTag("HearingPlayer"))
        {
            makingContact = true;
            aud.Play();
        }
    }

    void OnTriggerExit(Collider other) {
        if(other.gameObject.CompareTag("SeeingPlayer") || other.gameObject.CompareTag("HearingPlayer"))
        {
            makingContact = false;
            currentTimeToDrop = 0f;
        }
    }

    private void Update() 
    {
        if(makingContact && currentTimeToDrop < timeToDrop)
        {
            currentTimeToDrop += Time.deltaTime;
        }
        else if(makingContact && currentTimeToDrop >= timeToDrop)
        {
            currentTimeToDrop = 0f;
            rb.constraints = RigidbodyConstraints.None;
            makingContact = false;
        }
    }
}
