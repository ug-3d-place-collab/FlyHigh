using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShipController : MonoBehaviour
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

        // move the spaceship forward at a constant rate
        transform.Translate(speed * Time.deltaTime * Vector3.back);

        // tilt the spaceship up/down based on up/down arrow keys
        transform.Rotate(-rotationSpeed * verticalInput * Time.deltaTime * Vector3.left);
        transform.Rotate(rotationSpeed * horizontalInput * Time.deltaTime * Vector3.up);
    }
}
