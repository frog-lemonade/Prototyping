using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HugController : MonoBehaviour
{
    bool canHoldPlayer = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other) 
    {
        if(other.CompareTag("HearingPlayer"))
        {
            canHoldPlayer = true;
        }    
    }

    void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("HearingPlayer"))
        {
            canHoldPlayer = false;
        }  
    }
}
