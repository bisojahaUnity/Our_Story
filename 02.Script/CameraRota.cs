using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRota : MonoBehaviour
{
    float rx;
    float ry;
    public float rotSpeed = 200;

    void Update()
    {
        float mx = Input.GetAxis("Mouse X");
        float my = Input.GetAxis("Mouse Y");
        rx += my * rotSpeed * Time.deltaTime;
        ry += mx * rotSpeed * Time.deltaTime;

        rx = Mathf.Clamp(rx, -90, 90);
        transform.eulerAngles = new Vector3(-rx, ry, 0);
    }
}
