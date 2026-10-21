using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneCam : MonoBehaviour
{
    public GameObject plane;
    private Vector3 offset = new Vector3(5.25f, 3.35f, -11.6f);

    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = plane.transform.position + offset;
    }
}
