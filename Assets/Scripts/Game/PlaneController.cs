﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneController : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        // get the user's input
        float verticalInput = Input.GetAxis("Vertical");
        float horizontalInput = Input.GetAxis("Horizontal");

        // move the plane forward at a constant rate
        transform.Translate(speed * Time.deltaTime * Vector3.forward);

        // tilt the plane up/down
        transform.Rotate(-rotationSpeed * verticalInput * Time.deltaTime * Vector3.right);

        // tilt the plane left/right
        var angles = transform.localEulerAngles;
        angles.z = -horizontalInput * 20;
        transform.localEulerAngles = angles;

        transform.Rotate(rotationSpeed * horizontalInput * Time.deltaTime * Vector3.up);
    }
}
