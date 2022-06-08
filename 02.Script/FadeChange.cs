using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeManager : MonoBehaviour
{
    public float fadeTime = 5.0f;
    public float activeTime = 0.8f;
    Material mat;
    float lerpTime = 0.05f, lerpStart = 1.0f, lerpEnd = 0.0f;

    void Start()
    {
        mat = this.GetComponent<MeshRenderer>().material;
    }
    void Update()
    {
        FadeStart();
    }

    void FadeStart()
    {
        Color color = mat.color;
        lerpTime += Time.deltaTime / fadeTime;
        color.a = Mathf.Lerp(lerpStart, lerpEnd, lerpTime);
        mat.color = color;
        if (lerpTime > activeTime) this.gameObject.SetActive(false);
    }
}
