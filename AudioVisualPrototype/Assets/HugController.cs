using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HugController : MonoBehaviour
{
    bool canHoldPlayer = false;

    GameObject otherPlayer;

    DefaultControls _controlScheme;
    // Start is called before the first frame update
    void Awake()
    {
        _controlScheme = SceneLoadSetup.instance._controlScheme;
        _controlScheme.BasicControlsP1.MovementP1.performed += hug => AttemptHug();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void AttemptHug()
    {
        if(canHoldPlayer)
        {
            otherPlayer.transform.parent = this.transform;
            otherPlayer.GetComponent<Player2Controller>().SetHold(true);
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
