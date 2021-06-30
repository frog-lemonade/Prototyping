using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Controller : MonoBehaviour
{
    private CharacterController charController;
    public DefaultControls _controlScheme;

    private float moveDirY = 0f, horizMovement = 0f, vertMovement = 0f;
    public float gravity = 9.8f;
    public float walkSpeed = 5f;

    private Vector3 moveDirection = Vector3.zero;
    public float rotateSpeed = 2f;
    public bool sideScroll = true;

    private bool isBeingHeld = false;

    public float jumpHeight = 5f;

    ParticleSystem pingSystem;
    private void Awake() {

        charController = GetComponent<CharacterController>();
        _controlScheme = SceneLoadSetup.instance._controlScheme;
    }

    void Start()
    {
        _controlScheme.BasicControlsP1.MovementP2.performed += cont => HandleMoveInput(cont.ReadValue<Vector2>());
        _controlScheme.BasicControlsP1.MovementP2.canceled += cont => HandleMoveInput(Vector2.zero);

        _controlScheme.BasicControlsP1.HearingPlayerPing.performed += ping => ParticlePing();
        pingSystem = GetComponent<ParticleSystem>();
    }

    void ParticlePing()
    {
        if(!pingSystem.isPlaying)
            pingSystem.Play();
    }

    void FixedUpdate()
    {
        if(!isBeingHeld)
        {
            if(!charController.isGrounded)
            {
                moveDirY -= gravity * Time.deltaTime;
            }
            if(sideScroll)
            {
                if(vertMovement > 0 && charController.isGrounded)
                {
                    moveDirY += vertMovement * jumpHeight;
                }
                moveDirection = horizMovement * Vector3.right + new Vector3(0, moveDirY, 0);
                transform.eulerAngles = new Vector3(0, Mathf.Round(horizMovement) * 90, 0f);
                charController.Move(moveDirection * walkSpeed * Time.deltaTime);
            }
            else
            {
                transform.eulerAngles += new Vector3(0, horizMovement * rotateSpeed, 0);
                moveDirection = transform.forward * vertMovement;
                charController.Move(moveDirection * walkSpeed * Time.deltaTime);
            }
            //moveDirection = new Vector3(horizMovement, moveDirY, vertMovement);
            //moveDirection = transform.TransformDirection(moveDirection);

            //transform.eulerAngles = new Vector3(0, camController.rotationY, 0);
        }
        
    }

    void HandleMoveInput(Vector2 movementInput)
    {
        horizMovement = movementInput.x;
        vertMovement = movementInput.y;
    }

    public void SetHold(bool holdStatus)
    {
        isBeingHeld = holdStatus;
    }

    public bool GetHeld()
    {
        return isBeingHeld;
    }
}
