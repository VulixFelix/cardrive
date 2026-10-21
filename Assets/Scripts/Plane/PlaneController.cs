using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlaneController : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    public float verticalInput;

    public InputAction MoveAction;
    public Vector2 moveInput;

    // Start is called before the first frame update
    void Start()
    {
        MoveAction.Enable();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        moveInput = MoveAction.ReadValue<Vector2>();


        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(Vector3.right * Time.deltaTime * rotationSpeed * moveInput.y);
    }
}
