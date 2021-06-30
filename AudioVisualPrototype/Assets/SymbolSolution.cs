using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SymbolSolution : MonoBehaviour
{
    void OnTriggerEnter(Collider other) {
        if(other.CompareTag("SeeingPlayer"))
        {
            Debug.Log("Puzzle solved");
        }
    }
}
