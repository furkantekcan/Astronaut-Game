using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class CameraManager : MonoBehaviour
{
    public Transform target; // variable that we want camera to follow 
    public float cameraSpeed; // camera speed

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Slerp(transform.position, new Vector3(target.position.x, target.position.y, -10), cameraSpeed);//  start point (camera position ), end point (target position), speed
    }
}
