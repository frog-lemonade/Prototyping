using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveableLight : MonoBehaviour
{
    DefaultControls _controlScheme;
    bool canDrag = false;
    Transform prevParent = null;
    GameObject playerRef;
    bool isHeld = false;

    // Start is called before the first frame update
    void Start()
    {
        _controlScheme = SceneLoadSetup.instance._controlScheme;
        _controlScheme.BasicControlsP1.Hold.performed += drag => AttemptDrag();
    }

    void AttemptDrag()
    {
        if(canDrag && !isHeld)
        {
            prevParent = this.transform.parent;
            this.transform.parent = playerRef.transform;
            isHeld = true;
        }
        else if(canDrag && isHeld)
        {
            this.transform.parent = prevParent;
            prevParent = null;
            isHeld = false;
        }
    }

    private void OnTriggerEnter(Collider other) {
        if(other.CompareTag("SeeingPlayer"))
        {
            canDrag = true;
            playerRef = other.gameObject;
        }
    }

    private void OnTriggerExit(Collider other) {
        if(other.CompareTag("SeeingPlayer"))
        {
            canDrag = false;
            playerRef = null;
        }
    }
}
