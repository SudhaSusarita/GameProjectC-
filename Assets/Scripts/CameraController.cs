using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target;
    public Vector3 offset = new Vector3(0, 1, 0);
    public float distance = 5;
    public float cameraSpeed = 8;

    void Update()
    {
        Vector3 C_position = target.position + offset;
        this.transform.LookAt(C_position);

        if(Vector3.Distance(this.transform.position, C_position) > distance)
        {
            this.transform.Translate(0, 0, cameraSpeed * Time.deltaTime);
        }
    }
}
