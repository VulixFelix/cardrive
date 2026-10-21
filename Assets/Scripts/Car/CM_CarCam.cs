using UnityEngine;
using Unity.Cinemachine; // Cinemachine 3 namespace

public class CM_CarCam : MonoBehaviour
{
    [Header("Cinemachine Cameras")]
    public CinemachineCamera thirdPersonCam;
    public CinemachineCamera firstPersonCam;

    [Header("Input Settings")]
    public KeyCode switchKey = KeyCode.C;

    private bool isFirstPerson = false;

    void Start()
    {
        // Establish the baseline state at the start of the match
        thirdPersonCam.Priority = 10;
        firstPersonCam.Priority = 5;
    }

    void Update()
    {
        // Listen for the player's button press
        if (Input.GetKeyDown(switchKey))
        {
            ToggleCamera();
        }
    }

    void ToggleCamera()
    {
        isFirstPerson = !isFirstPerson;

        if (isFirstPerson)
        {
            // Give the 1st person camera higher priority to force a blend
            thirdPersonCam.Priority = 5;
            firstPersonCam.Priority = 10;
        }
        else
        {
            // Return priority to the 3rd person camera
            thirdPersonCam.Priority = 10;
            firstPersonCam.Priority = 5;
        }
    }
}
