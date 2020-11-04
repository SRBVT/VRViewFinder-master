using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointerInput : MonoBehaviour
{
    public Camera eventCamera;

    public int layerMask;
    public float maxDistance;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(Input.mousePosition);
        //Debug.Log(eventCamera);
        Ray ray = eventCamera.ScreenPointToRay(new Vector3(eventCamera.pixelWidth / 2, eventCamera.pixelHeight / 2, 0));

        //Ray ray = eventCamera.ScreenPointToRay(new Vector3(0, 0, 0));
        Debug.DrawRay(ray.origin, ray.direction * 10, Color.red);
        if (Physics.Raycast(ray, maxDistance, layerMask)){
            Debug.Log("Origin: " + ray.origin);
            Debug.Log("Direction: "+ ray.direction);
        }  
    }
}
