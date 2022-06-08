using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DoorRota : MonoBehaviour
{
    public Transform doorL;
    public Transform doorR;
    public Transform targetL;
    public Transform targetR;
    public float doorSpeed = 0.3f;

    void Update()
    {
        doorL.rotation = Quaternion.Slerp(doorL.rotation, targetL.rotation, Time.deltaTime * doorSpeed);
        doorR.rotation = Quaternion.Slerp(doorR.rotation, targetR.rotation, Time.deltaTime * doorSpeed);
    }
}
