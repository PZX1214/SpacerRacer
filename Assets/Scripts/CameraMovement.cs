using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//makes the camera move at a certain speed
public class CameraMovement : MonoBehaviour
{
   public float cameraSpeed;
   
    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(cameraSpeed * Time.deltaTime, 0, 0);
    }
}
