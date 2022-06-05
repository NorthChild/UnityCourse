using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class patrolMove : MonoBehaviour
{
    public float speed = 40.0f;
    public float xRange = 100;
    public float patrolRotation = 180.0f;

    public GameObject patrolDog;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        patrolDog.transform.Translate(Vector3.forward * Time.deltaTime * speed);
        // boundries
        if (patrolDog.transform.position.x < -xRange)
        {
            //transform.Translate(Vector3.forward * Time.deltaTime * speed);
            Destroy(patrolDog);
            //Instantiate(patrolDog, transform.position, patrolDog.transform.rotation);
            //patrolDog.transform.Translate(Vector3.forward * Time.deltaTime * speed);
            
        }
        else if (patrolDog.transform.position.x > xRange)
        {
           // patrolDog.transform.Translate(Vector3.forward * Time.deltaTime * speed);
            Destroy(patrolDog);
            //Instantiate(patrolDog, transform.position, patrolDog.transform.rotation);
            //patrolDog.transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }

}
}
