using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 20.0f;
    private float horizontalInput;
    private float forwardInput;
    private float turnSpeed = 45.0f;

    // Start is called before the first frame update

    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
        //actual input section
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        //Move the vehicle forward and rotates based on the input
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }
}
