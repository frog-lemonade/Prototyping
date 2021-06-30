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
        SceneLoadSetup.instance._controlScheme.BasicControlsP1.Camera.performed += look =>
        {
            inX = look.ReadValue<Vector2>().x;
            inY = look.ReadValue<Vector2>().y;
        };

        SceneLoadSetup.instance._controlScheme.BasicControlsP1.Camera.canceled += look =>
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
        if(pmController.sideScroll)
            transform.position = new Vector3(pmController.transform.position.x, pmController.transform.position.y, -10f);
        else
            this.transform.position = new Vector3(pmController.transform.position.x, pmController.transform.position.y + 10f, 0f);
    }

    public void SwapCamera()
    {
        if(pmController.sideScroll)
        {
            pmController.sideScroll = false;
            this.transform.position = new Vector3(pmController.transform.position.x, pmController.transform.position.y + 10f, 0f);
            this.transform.eulerAngles = new Vector3(90f, 90f, 0f);
        }
        else
        {
            pmController.sideScroll = true;
            this.transform.position = new Vector3(pmController.transform.position.x, pmController.transform.position.y, -10f);
            this.transform.eulerAngles = new Vector3(0f, 0f, 0f);
        }

    }
}
