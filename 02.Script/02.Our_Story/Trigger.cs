using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    public GameObject line_02;

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            line_02.gameObject.SetActive(true);
        }
    }
}
