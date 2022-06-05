using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{

    public float horizontalInput;
    public float spaceInput;

    public float speed = 10.0f;
    public float xRange = 18;
    public float rightBoundryX = 18;

    public GameObject foodPrefab;
    private Vector3 offset = new Vector3(0, 1.5f, 1.1f);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        spaceInput = Input.GetAxis("Horizontal");

        // plyr movement
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        // boundries
        if (transform.position.x < -xRange )
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        else if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        // fire/space input
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(foodPrefab, transform.position + offset, foodPrefab.transform.rotation);
        }

    }
}
