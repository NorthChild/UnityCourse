using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;

    public float antiSPAMCountdown = 0.8f;
    public float nextFire = 0.0f;

    void spawnDog()
    {
        Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {

        //Debug.Log($"Time = {Time.time}, nextFire = {nextFire}");
        
        // On spacebar press, spawn dog
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > nextFire)
        {
            nextFire = Time.time + antiSPAMCountdown;
            spawnDog();
        }
    }
}
