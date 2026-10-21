using UnityEngine;

public class OncomingTraffic : MonoBehaviour
{
    public float trafficSpeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.back * Time.deltaTime * trafficSpeed);
    }
}
