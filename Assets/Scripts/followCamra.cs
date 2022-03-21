using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followCamra : MonoBehaviour
{
    public Transform target;
    [Range(0, 1)]
    public float smoothSpeed = 0.2f;
    public Vector3 offset;

    private Camera cam;

    private void Start()
    {
        cam = GetComponent<Camera>();
    }
    

    void FixedUpdate()
    {
        Vector3 desiredPostion = target.position + offset;
        Vector3 smoothPosition = Vector3.Lerp(transform.position, desiredPostion, smoothSpeed);
        //cam.orthographicSize = Mathf.Lerp(7f, 4f, 0.2f);
        transform.position = smoothPosition;

        

        //transform.LookAt(playerTarget);
    }
}
