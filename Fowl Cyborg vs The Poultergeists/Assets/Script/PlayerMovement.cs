using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    //fields----------------------------------------------------------------------------------------------------------------

    [SerializeField]
    float speed = 1f;

    [SerializeField]
    Vector3 vehiclePosition = Vector3.zero;

    [SerializeField]
    Vector3 direction = Vector3.right;

    [SerializeField]
    Vector3 velocity = Vector3.zero;

    private Vector3 movementInput;

    private float totalCamHeight;
    private float totalCamWidth;

    //starting methods------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

    // Start is called before the first frame update
    void Start()
    {
        vehiclePosition = transform.position;;
        
    }

    // Update is called once per frame
    void Update()
    {
        Camera cameraObject = Camera.main;  
        float totalCamHeight = cameraObject.orthographicSize;
        float totalCamWidth = totalCamHeight * cameraObject.aspect;

        direction = movementInput;
        //direction = Quaternion.Euler(0, 0, turnAmount * Time.deltaTime) * direction;

        // velocity is direction * speed * deltaTime
        velocity = direction * speed * Time.deltaTime;

        // add velocity to the position
        vehiclePosition += velocity;
    

        if(vehiclePosition.x < -(totalCamWidth))
        {
            vehiclePosition = new Vector3(-(totalCamWidth), vehiclePosition.y, vehiclePosition.z);
        }
        if (vehiclePosition.x > totalCamWidth)
        {
            vehiclePosition = new Vector3(totalCamWidth, vehiclePosition.y, vehiclePosition.z);
        }
        if (vehiclePosition.y < -(totalCamHeight))
        {
            vehiclePosition = new Vector3(vehiclePosition.x, totalCamHeight, vehiclePosition.z);
        }
        if (vehiclePosition.y > totalCamHeight)
        {
            vehiclePosition = new Vector3(vehiclePosition.x, -(totalCamHeight), vehiclePosition.z);
        }

        // "draw" this vehicle at this position
        transform.position = vehiclePosition;


        // "draw" the vehicle looking in the direction it is looking
        // (if it's not already looking in that direction)
        if (direction != Vector3.zero)
        {
            transform.rotation = Quaternion.LookRotation(Vector3.forward, upwards: direction);
        }
    }


    //additional methods-------------------------------------------------------------------------------------------------------------------------

    /// <summary>
    /// allows the vehicle to move in the desired direction
    /// </summary>
    /// <param name="content"> the key that the player is pushing </param>
    public void OnMove(InputAction.CallbackContext content)
    {
        movementInput = content.ReadValue<Vector2>();
    }
}
