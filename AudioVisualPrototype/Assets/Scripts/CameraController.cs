using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    float inX = 0f;
    float inY = 0f;

    float rotationX = 0f;
    public float rotationY = 90f;

    public float sensitivityX = 5f;
    public float sensitivityY = 5f;

    public float minimumX = -60f;
    public float maximumX = 60f;
    public float minimumY = -306f;
    public float maximum = 360f;

    private PlayerMovementController pmController;
    // Start is called before the first frame update
    void Start()
    {
        pmController = transform.parent.GetComponentInChildren<PlayerMovementController>();
        pmController._controlScheme.BasicControlsP1.Camera.performed += look =>
        {
            inX = look.ReadValue<Vector2>().x;
            inY = look.ReadValue<Vector2>().y;
        };

        pmController._controlScheme.BasicControlsP1.Camera.canceled += look =>
        {
            inX = 0f;
            inY = 0f;
        };
    }

    // Update is called once per frame
    void Update()
    {
        //rotationY += inX * sensitivityX * Time.deltaTime;
        //rotationX += inY * sensitivityY * Time.deltaTime;

        // constrain x
        //rotationX = Mathf.Clamp(rotationX, minimumX, maximumX);
        // rotate game objects accordingly
        //transform.eulerAngles = new Vector3(-rotationX, rotationY, 0);
        transform.position = new Vector3(pmController.transform.position.x, pmController.transform.position.y, this.transform.position.z);
    }
}
