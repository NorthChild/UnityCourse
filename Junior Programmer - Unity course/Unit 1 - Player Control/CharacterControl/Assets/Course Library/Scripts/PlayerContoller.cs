using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerContoller : MonoBehaviour
{

    private float speed = 20.0f;
    private float turnSpeed = 25.0f;
    private float horizontalInput;
    private float verticalInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        
        // move forward or backwards
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
        //rotate left or right
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }
}
