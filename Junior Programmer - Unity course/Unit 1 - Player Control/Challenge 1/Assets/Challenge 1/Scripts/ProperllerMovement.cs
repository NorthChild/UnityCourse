using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProperllerMovement : MonoBehaviour
{
    public float propellerSpeed = 2150.0f;

    public GameObject propeller;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.Rotate(Vector3.forward * Time.deltaTime * propellerSpeed);
    }
}
