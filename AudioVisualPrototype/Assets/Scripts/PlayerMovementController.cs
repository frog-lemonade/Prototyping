using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementController : MonoBehaviour
{
    private CharacterController charController;
    public DefaultControls _controlScheme;

    private float moveDirY = 0f, horizMovement = 0f, vertMovement = 0f;
    public float gravity = 9.8f;
    public float walkSpeed = 5f;

    private Vector3 moveDirection = Vector3.zero;
   //private CameraController camController;

    public bool sideScroll = true;
    private void Awake() {
        charController = GetComponent<CharacterController>();
        _controlScheme = new DefaultControls();

        _controlScheme.BasicControlsP1.Enable();
        //camController = transform.parent.GetComponentInChildren<CameraController>();
    }

    void Start()
    {
        _controlScheme.BasicControlsP1.MovementP1.performed += cont => HandleMoveInput(cont.ReadValue<Vector2>());
        _controlScheme.BasicControlsP1.MovementP1.canceled += cont => HandleMoveInput(Vector2.zero);
    }

    void FixedUpdate()
    {
        if(!charController.isGrounded)
        {
            moveDirY -= gravity * Time.deltaTime;
        }
        if(sideScroll)
        {
            moveDirection = horizMovement * Vector3.right;
            if(vertMovement > 0 && charController.isGrounded)
            {
                moveDirection += vertMovement * Vector3.up;
            }
            transform.eulerAngles = new Vector3(0, Mathf.Round(horizMovement) * 90, 0f);
            charController.Move(moveDirection * walkSpeed * Time.deltaTime);
        }
        else
        {
            moveDirection = new Vector3(horizMovement, moveDirY, vertMovement);
            moveDirection = transform.TransformDirection(moveDirection);
            charController.Move(moveDirection * walkSpeed * Time.deltaTime);
            //transform.eulerAngles = new Vector3(0, camController.rotationY, 0);
        }
        
    }

    void HandleMoveInput(Vector2 movementInput)
    {
        horizMovement = movementInput.x;
        vertMovement = movementInput.y;
    }
}
