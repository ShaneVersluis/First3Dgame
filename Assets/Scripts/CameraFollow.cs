using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        //puts the camera behind the target
        //based on the values in the Vector3 called offset
        transform.position = target.position + offset;
    }
}
