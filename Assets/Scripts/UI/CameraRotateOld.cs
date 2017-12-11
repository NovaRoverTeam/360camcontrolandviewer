using UnityEngine;
using System.Collections;
using System;

public class CameraRotateOld : MonoBehaviour
{

   // public float minX = -360.0f;
    //public float maxX = 360.0f;

    //public float minY = -45.0f;
    //public float maxY = 45.0f;

    public float sensZ = 100.0f;
    public float sensY = 100.0f;

    float rotationY = 0.0f;
    float rotationZ = 0.0f;

    void Update()
    {

        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.LeftArrow) )
        {
            rotationZ += Input.GetAxis("Horizontal") * sensZ * Time.deltaTime;
            rotationY += Input.GetAxis("Vertical") * sensY * Time.deltaTime;
            //rotationY = Mathf.Clamp(rotationY, minY, maxY);
            transform.localEulerAngles = new Vector3(-rotationY, 0, rotationZ);
        }
    }
}