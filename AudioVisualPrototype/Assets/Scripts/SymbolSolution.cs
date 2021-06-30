using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SymbolSolution : MonoBehaviour
{
    bool canSolve = false;
    DefaultControls _controlScheme;
    public LockedDoor door;
    private void Start() 
    {
        _controlScheme = SceneLoadSetup.instance._controlScheme;
        _controlScheme.BasicControlsP1.Hold.performed += solve => AttemptSolve();
    }

    void AttemptSolve()
    {
        if(canSolve)
        {
            door.Open();
            Debug.Log("Puzzle solved");
        }
    }

    void OnTriggerEnter(Collider other) {
        if(other.CompareTag("SeeingPlayer"))
        {
            canSolve = true;
        }
    }

    void OnTriggerExit(Collider other) {
        if(other.CompareTag("SeeingPlayer"))
        {
            canSolve = false;
        }
    }
}
