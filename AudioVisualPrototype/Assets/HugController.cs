using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HugController : MonoBehaviour
{
    bool canHoldPlayer = false;

    GameObject otherPlayer;
    Transform prevParent = null;

    DefaultControls _controlScheme;
    // Start is called before the first frame update
    void Start()
    {
        _controlScheme = SceneLoadSetup.instance._controlScheme;
        _controlScheme.BasicControlsP1.Hold.performed += hug => AttemptHug();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void AttemptHug()
    {
        if(canHoldPlayer)
        {
            if(!otherPlayer.GetComponent<Player2Controller>().GetHeld())
            {
                prevParent = otherPlayer.transform.parent;
                otherPlayer.transform.parent = this.transform;
                otherPlayer.GetComponent<Player2Controller>().SetHold(true);
            }
            else
            {
                otherPlayer.transform.parent = prevParent;
                otherPlayer.GetComponent<Player2Controller>().SetHold(false);
                prevParent = null;
            }

        }
    }

    void OnTriggerEnter(Collider other) 
    {
        if(other.CompareTag("HearingPlayer"))
        {
            canHoldPlayer = true;
            otherPlayer = other.gameObject;
        }    
    }

    void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("HearingPlayer"))
        {
            canHoldPlayer = false;
            otherPlayer = null;
        }  
    }
}
