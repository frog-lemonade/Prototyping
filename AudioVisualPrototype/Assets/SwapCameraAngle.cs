using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwapCameraAngle : MonoBehaviour
{
    public GameObject cam;
    private void OnTriggerEnter(Collider other) {
        if(other.CompareTag("SeeingPlayer"))
        {
            cam.GetComponent<CameraController>().SwapCamera();
            this.gameObject.SetActive(false);
        }
    }
}
