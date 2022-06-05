using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class destroyOutOfBounds : MonoBehaviour
{

    private float topBoundry = 30.0f;
    private float lowerBoundry = -30.0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBoundry)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBoundry)
        {
            //Debug.Log("Animal left unfed");
            Destroy(gameObject);
        }
    }
}
