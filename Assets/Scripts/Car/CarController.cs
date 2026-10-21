using UnityEngine;
using UnityEngine.InputSystem;

public class CarController : MonoBehaviour
{

    //Makes it so the "speed" can be change without going into the script.
    public float speed = 20f;

    [Range (1f, 300f)]
    public float turnSpeed = 100f;
    
    public InputAction MoveAction;
    public Vector2 moveInput;

    // Start is called once before the first execution of Update after the MonoBehaviour is created.
    void Start()
    {
        MoveAction.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        //Gets the inputs of when player(You) pressed forwards/backwards
        moveInput = MoveAction.ReadValue<Vector2>();

        //Move the vehicle forward by 1 unit or metre per second. 
        //Time.deltaTime is basically 1 ups (unit per second) then you multiply it by x number.
        transform.Translate(Vector3.forward * Time.deltaTime * speed * moveInput.y);

        //Checks if the player is moving. If not turning won't work. If forwards/backwards movement is detected turning will work
        // this is also an alternative way of writing an if/else statement with 
        // • Condition ? ValueIfTrue : ValueIfFalse;
        float forwardTurn = (moveInput.y >0) ? turnSpeed : 0f;
        float backwardTurn = (moveInput.y <0) ? turnSpeed : 0f;

        //Rotates the vehicle side to side.
        transform.Rotate(Vector3.up, Time.deltaTime * forwardTurn * moveInput.x);
        transform.Rotate(Vector3.down, Time.deltaTime * backwardTurn * moveInput.x);
    }
}
