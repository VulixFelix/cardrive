using UnityEngine;

public class CarCam : MonoBehaviour
{
    public GameObject player;

    private Vector3 offset = new Vector3(0.0f, 4.5f, -8.0f);
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // LateUpdate is called once per frame, after Update
    void LateUpdate()
    {
        //Sets the camera position to the players position. Also puts the camera behind the player.
        transform.position = player.transform.position + offset;
    }
}
