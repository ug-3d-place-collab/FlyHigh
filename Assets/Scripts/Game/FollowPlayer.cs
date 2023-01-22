using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject plane;
    private Vector3 offset = new(0, 10, -20);

    // Start is called before the first frame update
    void Start()
    {
        transform.SetParent(plane.transform, false);
        transform.localPosition = offset;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        //float horizontalInput = Input.GetAxis("Horizontal");
        //transform.position = plane.transform.position + offset;
        //transform.rotation.SetEulerRotation(transform.rotation.x, plane.transform.rotation.y, transform.rotation.z);
        //transform.LookAt(plane.transform);
        //transform.RotateAround(plane.transform.position, Vector3.up, 100 * horizontalInput * Time.deltaTime);
        //transform.SetPositionAndRotation(transform.position, Quaternion.identity);
        //transform.RotateAround(plane.transform.position, Vector3.up, plane.transform.rotation.y);
        //transform.SetParent(plane.transform, false);
    }
}
