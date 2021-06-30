using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skylight : MonoBehaviour
{
    public GameObject lightObject;
    BoxCollider bxcollider;
    bool wasInCollider = false;
    AudioSource audio;
    bool inTimer;
    public float timeToUnlock = 4f;
    private float currentTimeToUnlock = 0f;

    public GameObject lockedDoor;

    // Start is called before the first frame update
    void Start()
    {
        bxcollider = GetComponent<BoxCollider>();
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(!wasInCollider && lightObject.transform.position.x <= bxcollider.bounds.max.x && lightObject.transform.position.x >= bxcollider.bounds.min.x)
        {
            wasInCollider = true;
            Debug.Log("Angel noises");
            audio.Play();
            inTimer = true;
        }
        else if(wasInCollider && !(lightObject.transform.position.x <= bxcollider.bounds.max.x && lightObject.transform.position.x >= bxcollider.bounds.min.x))
        {
            wasInCollider = false;
            inTimer = false;
            currentTimeToUnlock = 0f;
        }

        if(inTimer && currentTimeToUnlock < timeToUnlock)
        {
            currentTimeToUnlock += Time.deltaTime;
        }
        else if (inTimer && currentTimeToUnlock >= timeToUnlock)
        {
            currentTimeToUnlock = 0f;
            inTimer = false;
            lockedDoor.GetComponent<LockedDoor>().Open();
        }
    }
}
