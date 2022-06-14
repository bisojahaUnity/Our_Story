using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float gravity = 50.0f;
    CharacterController cc;
    public float moveSpeed = 3;
    Vector3 origin;

    void Start()
    {
        cc = GetComponent<CharacterController>();
        origin = this.transform.position;

    }

    void Update()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Vector3 dir = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        dir = Camera.main.transform.TransformDirection(dir);
        dir.y = 0.0f;
        dir.y -= gravity * Time.deltaTime;

        dir.Normalize();
        transform.right = Camera.main.transform.right;
        cc.Move(dir * moveSpeed * Time.deltaTime);
    }
}
