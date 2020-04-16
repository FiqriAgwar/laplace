using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollower : MonoBehaviour
{
    public Transform cameraTarget;
    public float speed = 10f;
    public Vector3 offset;
    public Transform lookTarget;

    void LateUpdate() {
        Vector3 destinedPosition = cameraTarget.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, destinedPosition, speed * Time.deltaTime);
        transform.position = smoothedPosition;
        transform.LookAt(lookTarget.position);
    }
}
