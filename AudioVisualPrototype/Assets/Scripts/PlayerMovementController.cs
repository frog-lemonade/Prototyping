using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementController : MonoBehaviour
{
    private CharacterController charController;
    private DefaultControls _controlScheme;

    private float moveDirY = 0f, horizMovement = 0f, vertMovement = 0f;
    public float gravity = 9.8f;
    public float walkSpeed = 5f;

    private Vector3 moveDirection = Vector3.zero;
 
    void Start()
    {
        charController = GetComponent<CharacterController>();
        _controlScheme = new DefaultControls();

        _controlScheme.BasicControlsP1.Enable();
        _controlScheme.BasicControlsP1.Movement.performed += cont => HandleMoveInput(cont.ReadValue<Vector2>());
        _controlScheme.BasicControlsP1.Movement.canceled += cont => HandleMoveInput(Vector2.zero);
    }

    void FixedUpdate()
    {
        if(!charController.isGrounded)
        {
            moveDirY -= gravity * Time.deltaTime;
        }
        moveDirection = new Vector3(horizMovement, moveDirY, vertMovement);
        moveDirection = transform.TransformDirection(moveDirection);
        charController.Move(moveDirection * walkSpeed * Time.deltaTime);
    }

    void HandleMoveInput(Vector2 movementInput)
    {
        Debug.Log("Buttons pressed " + movementInput);
        horizMovement = movementInput.x;
        vertMovement = movementInput.y;
    }
}
